using System;
using PLChecker;
using Prolog;

class Program
{
    static void Main(string[] args)
    {
        //write examples file
        ConvertExamples convert = new ConvertExamples();
        convert.writeExamples();

        //read examples file
        ReadExamples read = new ReadExamples();
        List<string> examples = read.Read();

        var prolog = new PrologEngine(persistentCommandHistory: false);
        prolog.Consult("C:\\Users\\micha\\Desktop\\PLChecker\\PLChecker\\input\\domain.pl");

        using (StreamWriter writeFile = new StreamWriter(@"C:\Users\micha\Desktop\PLChecker\PLChecker\output\results.txt"))
        {
            foreach (var example in examples)
            {
                var solution = prolog.GetFirstSolution(query: example);
                writeFile.WriteLine($"{example}" + $"{solution}\n");
            }
        }
    }
}