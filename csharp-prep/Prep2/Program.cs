using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage?:");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        string grade;
        string sign;

        // Letter Grade
        if (percentage >= 90)
        {
            grade = "A";
        }

        else if (percentage >= 80)
        {
            grade = "B";
        }

        else if (percentage >= 70)
        {
            grade = "C";
        }

        else if (percentage >= 60)
        {
            grade = "D";
        }

        else
        {
            grade = "F";
        }


        if (percentage >= 97 || percentage < 60)
        {
            sign = "";
            Console.WriteLine($"{grade}{sign}");
        }

        else
        {
            if (percentage % 10 >= 7)
            {
                sign = "+";
                Console.WriteLine($"{grade}{sign}");
            }

            else if (percentage % 10 < 3)
            {
                sign = "-";
                Console.WriteLine($"{grade}{sign}");
            }
            else
            {
                sign = "";
                Console.WriteLine($"{grade}{sign}");
            }
        }
        // sign


        // decision
        if (grade == "A" || grade == "B" || grade == "C")
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else
        {
            Console.WriteLine("Better Luck Next Time!");
        }




    }
}