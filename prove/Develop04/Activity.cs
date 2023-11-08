using System.Diagnostics;

public class Activity
{
    private string _description;
    protected int _durationInSeconds;
    private string _name;

    public int spinnerCounter;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?: ");
        string seconds = Console.ReadLine();
        _durationInSeconds = int.Parse(seconds);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        DisplaySpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_durationInSeconds} seconds of {_name}!");
        DisplaySpinner(5);
        Console.Clear();

    }

    public void DisplaySpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountdownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}