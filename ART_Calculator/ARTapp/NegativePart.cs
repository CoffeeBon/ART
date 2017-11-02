using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTapp
{
    class NegativePart : Calculation
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
        //    set { _PeakIndex = value; }
        //}

        public NegativePart(double[] getSmoothingData) { this.getSmoothingData = getSmoothingData; }

        public List<double> N_PeakIndex()
        {
            List<double> N_PeakIndex = new List<double>();
            for (int i = 1; i < getSmoothingData.Length - 1; i++)
            {
                if (getSmoothingData[i + 1] - getSmoothingData[i] > 0 && getSmoothingData[i] - getSmoothingData[i - 1] < 0)
                { N_PeakIndex.Add(Array.IndexOf(getSmoothingData, getSmoothingData[i])); }
                else if (getSmoothingData[i + 1] - getSmoothingData[i] == 0)
                { N_PeakIndex.Add(Array.IndexOf(getSmoothingData, getSmoothingData[i])); }
            }
            return N_PeakIndex;
        }

        public List<double> N_PeakData()
        {
            List<double> N_PeakData = new List<double>();
            for (int i = 1; i < getSmoothingData.Length - 1; i++)
            {
                if (getSmoothingData[i + 1] - getSmoothingData[i] > 0 && getSmoothingData[i] - getSmoothingData[i - 1] < 0)
                { N_PeakData.Add(getSmoothingData[i]); }
                else if (getSmoothingData[i + 1] - getSmoothingData[i] == 0)
                { N_PeakData.Add(getSmoothingData[i]); }
            }
            return N_PeakData;
        }

    }
}
