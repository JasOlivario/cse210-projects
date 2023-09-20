using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess;
        int count = 0;

        string playAgain;

        do
        {
            do
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    count++;
                }

                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    count++;
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    count++;
                }
            } while (guess != number);
            Console.WriteLine($"It took you {count} guesses!");
            Console.Write("Do you want to play again?");
            playAgain = Console.ReadLine();
            count = 0;
        } while (playAgain == "yes");

    }
}