using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;

        while (userInput != 4)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Start Breathing Activity. \n 2. Start Reflecting Activity \n 3. Start Listing Activity \n 4. Quit");

            Console.Write("Select a choice from the menu: ");
            string userEntry = Console.ReadLine();
            userInput = int.Parse(userEntry);

            Console.Clear();

            switch (userInput)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    Console.Clear();
                    breathing.Run();
                    break;
                case 2:
                    ReflectionActivity reflection = new ReflectionActivity();
                    Console.Clear();
                    reflection.Run();
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    Console.Clear();
                    listing.Run();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using this program! Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please choose a valid response.");
                    break;
            }

        }

    }
}