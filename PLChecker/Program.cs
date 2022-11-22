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

        foreach (var example in examples)
        {

        }


        var solution = prolog.GetFirstSolution(query: "move_t_to_b(b5,b8,p48).");

        Console.WriteLine(solution.Solved);
    }
}