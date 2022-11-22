using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLChecker
{
    //Used for experiments only, reverses pos/neg examples
    class Reverser
    {
        public void ReverseExamples()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\micha\Desktop\PLChecker\PLChecker\input\examples.pl");
            List<string> output = new List<string>();

            foreach (var line in lines)
            {
                if (line.Contains("pos"))
                {
                    var replace = line.Replace("pos", "neg");
                    output.Add(replace);
                } else if (line.Contains("neg"))
                {
                    var replace = line.Replace("neg", "pos");
                    output.Add(replace);
                }
            }

            using (StreamWriter writeFile = new StreamWriter("C:\\Users\\micha\\Desktop\\PLChecker\\PLChecker\\output\\reversed.pl"))
            {
                foreach (var line in output)
                {
                    writeFile.WriteLine(line);
                }
            }

        }
    }
}
