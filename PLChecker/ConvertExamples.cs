using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLChecker
{
    class ConvertExamples
    {
        public void writeExamples()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\micha\Desktop\PLChecker\PLChecker\input\examples.pl");
            List<string> examples = new List<string>();

            foreach (var line in lines)
            {
                if (line.Contains("pos") || line.Contains("neg"))
                {
                    string result = line.Remove(0, 4);
                    examples.Add(result);
                }
            }

            using (StreamWriter writeFile = new StreamWriter("C:\\Users\\micha\\Desktop\\PLChecker\\PLChecker\\output\\examples.pl"))
            {
                foreach (var line in examples)
                {
                    string immediate = line.Substring(0, line.LastIndexOf(")."));
                    immediate += @".";

                    writeFile.WriteLine(immediate);
                }
            }

        }
    }
}
