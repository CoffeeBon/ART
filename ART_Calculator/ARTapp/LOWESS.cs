using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ARTapp
{
    public class LOWESS
    {
        public static double DEFAULT_BANDWIDTH = 0.01;
        public static int DEFAULT_ROBUSTNESS_ITERS = 2;
        private double bandwidth;
        private int robustnessIters;

        public LOWESS()
        {
            this.bandwidth = DEFAULT_BANDWIDTH;
            this.robustnessIters = DEFAULT_ROBUSTNESS_ITERS;
        }

        public LOWESS(double bandwidth, int robustnessIters)
        {
            if (bandwidth < 0 || bandwidth > 1)
            {
                throw new ApplicationException(string.Format(
                "bandwidth must be in the interval [0,1], but got {0}", bandwidth));
            }
            this.bandwidth = bandwidth;
            if (robustnessIters < 0)
            {
                throw new ApplicationException(string.Format(
                   "the number of robustness iterations must be non-negative, but got {0}", robustnessIters));
            }
            this.robustnessIters = robustnessIters;
        }

        public double[] smooth(double[] xval, double[] yval)
        {
            if (xval.Length != yval.Length)
            {
                throw new ApplicationException(string.Format(
                       "Loess expects the abscissa and ordinate arrays to be of the same size, but got {0} abscisssae and {1} ordinatae", xval.Length, yval.Length));
            }

            int n = xval.Length;

            if (n == 0) { throw new ApplicationException("Loess expects at least 1 point"); }

            checkAllFiniteReal(xval, true);
            checkAllFiniteReal(yval, false);
            checkStrictlyIncreasing(xval);

            if (n == 1) { return new double[] { yval[0] }; }
            if (n == 2) { return new double[] { yval[0], yval[1] }; }

            int bandwidthInPoints = (int)(bandwidth * n);

            if (bandwidthInPoints < 2)
            {
                throw new ApplicationException(string.Format(
                    "the bandwidth must be large enough to accomodate at least 2 points. There are {0} "
                    + " data points, and bandwidth must be at least {1} but it is only {2}"
                    , n, 2.0 / n, bandwidth));
            }

            double[] res = new double[n];
            double[] residuals = new double[n];
            double[] sortedResiduals = new double[n];
            double[] robustnessWeights = new double[n];

            // Do an initial fit and 'robustnessIters' robustness iterations.
            // This is equivalent to doing 'robustnessIters+1' robustness iterations
            // starting with all robustness weights set to 1.

            Parallel.For(0, robustnessWeights.Length, i => { robustnessWeights[i] = 1; });
            for (int iter = 0; iter <= robustnessIters; ++iter)
            {
                int[] bandwidthInterval = { 0, bandwidthInPoints - 1 };

                for (int i = 0; i < n; ++i) // At each x, compute a local weighted linear regression
                {
                    double x = xval[i];

                    // Find out the interval of source points on which
                    // a regression is to be made.
                    if (i > 0) { updateBandwidthInterval(xval, i, bandwidthInterval); }

                    int ileft = bandwidthInterval[0];
                    int iright = bandwidthInterval[1];

                    // Compute the point of the bandwidth interval that is
                    // farthest from x
                    int edge;
                    if (xval[i] - xval[ileft] > xval[iright] - xval[i]) { edge = ileft; }
                    else { edge = iright; }

                    // Compute a least-squares linear fit weighted by
                    // the product of robustness weights and the tricube
                    // weight function.
                    // See http://en.wikipedia.org/wiki/Linear_regression
                    // (section "Univariate linear case")
                    // and http://en.wikipedia.org/wiki/Weighted_least_squares
                    // (section "Weighted least squares")
                    double sumWeights = 0;
                    double sumX = 0;
                    double sumXSquared = 0;
                    double sumY = 0;
                    double sumXY = 0;
                    double denom = Math.Abs(1.0 / (xval[edge] - x));

                    for (int k = ileft; k <= iright; ++k)
                    {
                        double xk = xval[k];
                        double yk = yval[k];
                        double dist;

                        if (k < i) { dist = (x - xk); }
                        else { dist = (xk - x); }

                        double w = tricube(dist * denom) * robustnessWeights[k];
                        double xkw = xk * w;

                        sumWeights += w;
                        sumX += xkw;
                        sumXSquared += xk * xkw;
                        sumY += yk * w;
                        sumXY += yk * xkw;
                    }

                    double meanX = sumX / sumWeights;
                    double meanY = sumY / sumWeights;
                    double meanXY = sumXY / sumWeights;
                    double meanXSquared = sumXSquared / sumWeights;

                    double beta;
                    if (meanXSquared == meanX * meanX)
                    { beta = 0; }
                    else { beta = (meanXY - meanX * meanY) / (meanXSquared - meanX * meanX); }

                    double alpha = meanY - beta * meanX;

                    res[i] = beta * x + alpha;
                    residuals[i] = Math.Abs(yval[i] - res[i]);
                }

                // No need to recompute the robustness weights at the last
                // iteration, they won't be needed anymore
                if (iter == robustnessIters) { break; }

                // Recompute the robustness weights.
                // Find the median residual.

                System.Array.Copy(residuals, sortedResiduals, n); //System.arraycopy(residuals, 0, sortedResiduals, 0, n);

                Array.Sort<double>(sortedResiduals);
                double medianResidual = sortedResiduals[n / 2];

                if (medianResidual == 0) { break; }

                Parallel.For(0, n, i =>
                {
                    double arg = residuals[i] / (6 * medianResidual);
                    robustnessWeights[i] = (arg >= 1) ? 0 : Math.Pow(1 - arg * arg, 2);
                });
            }
            return res;
        }

        /**
         * Given an index interval into xval that embraces a certain number of
         * points closest to xval[i-1], update the interval so that it embraces
         * the same number of points closest to xval[i]
         *
         * @param xval arguments array
         * @param i the index around which the new interval should be computed
         * @param bandwidthInterval a two-element array {left, right} such that:
         * (left==0 or xval[i] - xval[left-1] > xval[right] - xval[i])
         *  and also 
         * (right==xval.length-1 or xval[right+1] - xval[i] > xval[i] - xval[left])
         * The array will be updated.
         */
        private static void updateBandwidthInterval(double[] xval, int i, int[] bandwidthInterval)
        {
            int left = bandwidthInterval[0];
            int right = bandwidthInterval[1];

            //// The right edge should be adjusted if the next point to the right
            //// is closer to xval[i] than the leftmost point of the current interval
            //int nextRight = nextNonzero(weights, right);
            //if (nextRight < xval.Length && xval[nextRight] - xval[i] < xval[i] - xval[left])
            //{
            //    int nextLeft = nextNonzero(weights, bandwidthInterval[0]);
            //    bandwidthInterval[0] = nextLeft;
            //    bandwidthInterval[1] = nextRight;
            //} => Error Code

            // The edges should be adjusted if the previous point to the
            // left is closer to x than the current point to the right or
            // if the next point to the right is closer
            // to x than the leftmost point of the current interval
            if (left != 0 && xval[i] - xval[left - 1] < xval[right] - xval[i])
            {
                bandwidthInterval[0]++;
                bandwidthInterval[1]++;
            }
            else if (right < xval.Length - 1 && xval[right + 1] - xval[i] < xval[i] - xval[left])
            {
                bandwidthInterval[0]++;
                bandwidthInterval[1]++;
            }
        }

        /* Compute the  weight function
         * @param x the argument
         * @return (1-|x|^3)^3
         */
        private static double tricube(double x)
        {
            double tmp = Math.Abs(x);
            double tricubeTmp = 1 - tmp * tmp * tmp;
            return tricubeTmp * tricubeTmp * tricubeTmp;
        }

        /**
         * Check that all elements of an array are finite real numbers.
         *
         * @param values the values array
         * @param isAbscissae if true, elements are abscissae otherwise they are ordinatae
         * @throws MathException if one of the values is not a finite real number
         */
        private static void checkAllFiniteReal(double[] values, bool isAbscissae)
        {
            Parallel.For(0, values.Length, i => {
                double x = values[i];
                if (Double.IsInfinity(x) || Double.IsNaN(x))
                {
                    string pattern = isAbscissae ?
                            "all abscissae must be finite real numbers, but {0}-th is {1}" :
                            "all ordinatae must be finite real numbers, but {0}-th is {1}";
                    throw new ApplicationException(string.Format(pattern, i, x));
                }
            });
        }

        /**
         * Check that elements of the abscissae array are in a strictly
         * increasing order.
         *
         * @param xval the abscissae array
         * @throws MathException if the abscissae array is not in a strictly increasing order
         */
        private static void checkStrictlyIncreasing(double[] xval)
        {
            Parallel.For(0, xval.Length, i => {
                if (i >= 1 && xval[i - 1] >= xval[i])
                {
                    throw new ApplicationException(string.Format(
                            "the abscissae array must be sorted in a strictly " +
                            "increasing order, but the {0}-th element is {1} " +
                            "whereas {2}-th is {3}",
                            i - 1, xval[i - 1], i, xval[i]));
                }
            });
        }
    }
}
