using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Joshue Olivario", "Mathematics");
        string summary = a.GetSummary();
        Console.WriteLine(summary);

        MathAssignment ma = new MathAssignment("Aila Olivario", "Fractions", 7.3, "8-19");
        string hwList = ma.GetHomeworkList();
        Console.WriteLine(hwList);

        WritingAssignment essay = new WritingAssignment("Belle Olivario", "European History", "The Causes of World War II");
        string e = essay.GetWritingInformation();
        Console.WriteLine(e);
    }

}
