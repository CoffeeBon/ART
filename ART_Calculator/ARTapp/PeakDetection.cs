using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTapp
{
    class PeakDetection
    {
        public List<double> P_PeakIndex(double[] getSmoothingData)
        {
            List<double> p_DataIndex = new List<double>();
            for (int i = 1; i < getSmoothingData.Length - 1; i++)
            {
                if (getSmoothingData[i + 1] - getSmoothingData[i] < 0 && getSmoothingData[i] - getSmoothingData[i - 1] > 0)
                { p_DataIndex.Add(Array.IndexOf(getSmoothingData, getSmoothingData[i])); }
                else if (getSmoothingData[i + 1] - getSmoothingData[i] == 0)
                { p_DataIndex.Add(Array.IndexOf(getSmoothingData, getSmoothingData[i])); }
            }
            return p_DataIndex;
        }

        public List<double> P_PeakData(double[] getSmoothingData)
        {
            List<double> p_PeakData = new List<double>();
            for (int i = 1; i < getSmoothingData.Length - 1; i++)
            {
                if (getSmoothingData[i + 1] - getSmoothingData[i] < 0 && getSmoothingData[i] - getSmoothingData[i - 1] > 0)
                { p_PeakData.Add(getSmoothingData[i]); }
                else if (getSmoothingData[i + 1] - getSmoothingData[i] == 0)
                { p_PeakData.Add(getSmoothingData[i]); }
            }
            return p_PeakData;
        }

        public List<double> N_PeakIndex(double[] getSmoothingData)
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

        public List<double> N_PeakData(double[] getSmoothingData)
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
