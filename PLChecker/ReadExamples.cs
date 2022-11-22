using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLChecker
{
    class ReadExamples
    {
        public List<string> Read()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\micha\Desktop\PLChecker\PLChecker\output\examples.pl");
            List<string> examples = new List<string>();

            foreach (string line in lines)
            {
                examples.Add(line);
            }

            return examples;
        }
    }
}