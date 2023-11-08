using System.Reflection.Metadata.Ecma335;
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ")
    {

    }

    private void ShowBreatheInMessage(int duration)
    {
        Console.Write("Breathe in...");
        ShowCountdownTimer(duration);
    }

    private void ShowBreatheOutMessage(int duration)
    {
        Console.Write("Breathe out...");
        ShowCountdownTimer(duration);
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationInSeconds);

        while (DateTime.Now < endTime)
        {
            ShowBreatheInMessage(4);
            Console.WriteLine();
            ShowBreatheOutMessage(6);
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.Clear();
        DisplayEndingMessage();

    }
}