using System.Globalization;

public class ListingActivity : Activity
{
    List<string> _listingPrompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ")
    {

    }

    private string GetRandomPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Random randomPrompt = new Random();
        int randIndex = randomPrompt.Next(_listingPrompts.Count);
        string random = _listingPrompts[randIndex];

        return $" --- {random} ---";


    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(5);
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdownTimer(5);
        Console.WriteLine();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationInSeconds);

        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine();

        Console.WriteLine($"You listed {count} items");
        DisplayEndingMessage();

    }




}