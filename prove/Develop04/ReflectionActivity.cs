using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts = new List<string>() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }


    private List<string> GetQuestions()
    {
        return _questions;
    }

    private string GetRandomPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Random randomPrompt = new Random();
        int randIndex = randomPrompt.Next(_reflectionPrompts.Count);
        string random = _reflectionPrompts[randIndex];

        return $" --- {random} ---";

    }

    private string GetRandomQuestion()
    {
        // Duplicate Random Questions appears//
        // Random randomQuestion = new Random();
        // int randIndex = randomQuestion.Next(GetQuestions().Count);
        // string random = GetQuestions()[randIndex];
        // return $"> {random}";

        // removes used quest to avoid duplicates
        Random randomQuestion = new Random();
        List<string> availableQuestions = GetQuestions();

        if (availableQuestions.Count == 0)
        {
            return "No more questions available.";
        }

        int randIndex = randomQuestion.Next(availableQuestions.Count);
        string random = availableQuestions[randIndex];

        availableQuestions.RemoveAt(randIndex);

        return $"> {random}";

    }

    private void InitializeActivity()
    {
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now Ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountdownTimer(5);
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(5);
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        InitializeActivity();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationInSeconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(GetRandomQuestion());
            DisplaySpinner(10);
            Console.WriteLine();
        }

        Console.Clear();
        DisplayEndingMessage();

    }
}