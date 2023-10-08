using System.Runtime.InteropServices;

public class PrompGenerator
{
    List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    // new codes
    List<string> _spiritualPrompts = new List<string>() {
        "What have you learned from the Scriptures today?",
        "What have you learned from the recent General Conference?",
        "How did you feel about your last testimony bearing experience?",
        "What was the last thing yout thought in your Family Home Evening?",
        "Have you learned about Christ today? Explain how."
    };

    // new codes
    List<string> _familyPrompts = new List<string>() {
        "What are the memorable experiences you've had with your family today?",
        "How are you able to help with household chores today?",
        "Describe today's vibe at home",
        "What are the good words that you've told your wife today?",
        "What are the news things you've taught your Children?"
    };

    // new codes
    public string _topic = "1. General \n 2. Family \n 3. Spiritual";

    public string DisplayRandomPrompt()
    {
        Random randomPrompt = new Random();
        int randIndex = randomPrompt.Next(_prompts.Count);
        string random = _prompts[randIndex];

        return random;

    }

    public string DisplayFamilyPrompt()
    {
        Random randomPrompt = new Random();
        int randIndex = randomPrompt.Next(_familyPrompts.Count);
        string random = _familyPrompts[randIndex];

        return random;

    }

    public string DisplaySpiritualPrompt()
    {
        Random randomPrompt = new Random();
        int randIndex = randomPrompt.Next(_spiritualPrompts.Count);
        string random = _spiritualPrompts[randIndex];

        return random;

    }

    // new codes
    public void DisplayTopic()
    {
        Console.WriteLine("What do you like to write about?");
        Console.WriteLine(_topic);

    }

}