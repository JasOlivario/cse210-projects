using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        static void DisplayResult()
        {
            string name = PromptUserName();
            int num = PromptUserNumber();
            int squared = SquareNumber(num);
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }
        DisplayResult();


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

}