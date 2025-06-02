using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Christiana Nwachukwu", "Fractions", "7.3", "3-10");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War 11");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}