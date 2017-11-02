using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTapp
{
    class PositivePart : Calculation
    {
        private double[] getSmoothingData { get; }
        //private List<double> _PeakData = new List<double>();

        //public List<double> PeakData
        //{
        //    get { return _PeakData; }
        //}

        //private List<double> _PeakIndex = new List<double>();
        //public List<double> PeakIndex
        //{
        //    get { return _PeakIndex; }

        //}

        public PositivePart(double[] getSmoothingData) { this.getSmoothingData = getSmoothingData; }

        public List<double> P_PeakIndex()
        {
            List<double> _PeakIndex = new List<double>();
            for (int i = 1; i < getSmoothingData.Length - 1; i++)
            {

                if (getSmoothingData[i + 1] - getSmoothingData[i] < 0 && getSmoothingData[i] - getSmoothingData[i - 1] > 0)
                { _PeakIndex.Add(Array.IndexOf(getSmoothingData, getSmoothingData[i])); }

                else if (getSmoothingData[i + 1] - getSmoothingData[i] == 0)
                { _PeakIndex.Add(Array.IndexOf(getSmoothingData, getSmoothingData[i])); }
            }
            return _PeakIndex;

        }

        public List<double> P_PeakData()
        {
            List<double> _PeakData = new List<double>();
            for (int i = 1; i < getSmoothingData.Length - 1; i++)
            {
                if (getSmoothingData[i + 1] - getSmoothingData[i] < 0 && getSmoothingData[i] - getSmoothingData[i - 1] > 0)
                { _PeakData.Add(getSmoothingData[i]); }

                else if (getSmoothingData[i + 1] - getSmoothingData[i] == 0)
                { _PeakData.Add(getSmoothingData[i]); }
            }
            return _PeakData;
        }
    }
}
