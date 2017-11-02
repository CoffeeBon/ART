using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTapp
{
    class FrozenAnalysis
    {
        private double FrozenTorque { get; set; }
        public FrozenAnalysis()
        {

        }
        public double FrozenProcedure(double[] lowessFrozenTime,double[] lowessFrozenTorque)
        {
            LOWESS frozenLowess = new LOWESS();
            PeakDetection frozenPeak = new PeakDetection();


            double PositiveFrozen = frozenPeak.P_PeakData(frozenLowess.smooth(lowessFrozenTime, lowessFrozenTorque)).Average();
            double NegativeFrozen = frozenPeak.N_PeakData(frozenLowess.smooth(lowessFrozenTime, lowessFrozenTorque)).Average();
            return FrozenTorque = (Math.Abs(PositiveFrozen)+Math.Abs(NegativeFrozen))/2;
        }
        
    }
}
