using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ARTapp
{
    class RawdataInputFile
    {
        //private string _FileAdress;
        //public string FileAdress
        //{ get { return _FileAdress; } set { _FileAdress = value; } }

        public RawdataInputFile(string fileAdress, List<double> times, List<double> torques, List<double> phases)
        {
            FileStream inputFile = new FileStream(fileAdress, FileMode.Open, FileAccess.Read);
            StreamReader fileRead = new StreamReader(inputFile);

            int ReadIndex = 0;
            while (!fileRead.EndOfStream)
            {
                string line = fileRead.ReadLine();
                string[] parts = line.Split('\t');
                times.Add(double.Parse(parts[0]));
                torques.Add(double.Parse(parts[1]));
                phases.Add(double.Parse(parts[2]));

                ReadIndex++;
            }
        }

    }
}
