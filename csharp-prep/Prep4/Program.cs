using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        Console.WriteLine();

        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter Number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            numbers.Add(number);

        } while (number != 0);

        int sum = numbers.Sum();
        double average = (double)sum / (numbers.Count - 1);
        int max = numbers.Max();

        int min = numbers[0];

        foreach (int item in numbers)
        {
            if (item < min && item > 0)
            {
                // if this number is greater than the max, we have found the new max!
                min = item;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The smallest positive number is: {min}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine("The Sorted List is:");

        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            int item = numbers[i];
            Console.WriteLine(item);
        }


    }
}