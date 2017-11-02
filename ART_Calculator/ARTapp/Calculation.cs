using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTapp
{
    class Calculation
    {
        private double tl { get; set; }
        private double mtq { get; set; }
        private double[] getSmoothingData { get; }

        public Calculation()
        {

        }

        public double CalculateEffectiveTorque(List<double> getTorqueIndex, List<double> getPhaseIndex, List<double> getTorqueData, int signalPeriod, double crossTime, double testPeriod, double frozenTQ)
        {
            tl = TimeLag(getTorqueIndex, getPhaseIndex, signalPeriod, crossTime);
            mtq = TorqueMean(getTorqueData);
            return Math.Sqrt(Math.Pow((CosineProcess(tl, mtq, testPeriod) - frozenTQ), 2) + Math.Pow(SineProcess(tl, mtq, testPeriod), 2));
        }

        public double CalculateEffectivePhaseLag(List<double> getTorqueIndex, List<double> getPhaseIndex, List<double> getTorqueData, int signalPeriod, double crossTime, double testPeriod, double frozenTQ)
        {
            tl = TimeLag(getTorqueIndex, getPhaseIndex, signalPeriod, crossTime);
            mtq = TorqueMean(getTorqueData);
            if (Math.Atan((SineProcess(tl, mtq, testPeriod)) / (CosineProcess(tl, mtq, testPeriod) - frozenTQ)) * 180 / Math.PI > 0)
            {
                return (Math.Atan((SineProcess(tl, mtq, testPeriod)) / (CosineProcess(tl, mtq, testPeriod) - frozenTQ))) * 180 / Math.PI;
            }
            else
            {
                return ((Math.Atan((SineProcess(tl, mtq, testPeriod)) / (CosineProcess(tl, mtq, testPeriod) - frozenTQ))) + Math.PI) * 180 / Math.PI;
            }
        }


        private double TimeLag(List<double> getTorqueIndex, List<double> getPhaseIndex, int signalPeriod, double crossTime)
        {
            List<double> TimeLagList = new List<double>();

            for (int i = 0; i < signalPeriod; i++)
            {
                if (getTorqueIndex[i] - getPhaseIndex[i] > 0)
                {
                    TimeLagList.Add((getTorqueIndex[i] - getPhaseIndex[i]) * crossTime);
                }
                else
                {
                    TimeLagList.Add((getTorqueIndex[i + 1] - getPhaseIndex[i]) * crossTime);
                }
            }
            return Math.Abs(TimeLagList.Average());
        }

        private double TorqueMean(List<double> getTorqueData)
        {
            return Math.Abs(getTorqueData.Average());
        }

        private double CosineProcess(double timeLagMean, double torqueMean, double testPeriod)
        {
            return Math.Abs(torqueMean * Math.Cos(2 * Math.PI * timeLagMean / testPeriod));
        }

        private double SineProcess(double timeLagMean, double torqueMean, double testPeriod)
        {
            return Math.Abs(torqueMean * Math.Sin(2 * Math.PI * timeLagMean / testPeriod));
        }
    }
}
