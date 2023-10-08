using System;
using System.ComponentModel;
using System.Net;


class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        PrompGenerator prompt = new PrompGenerator();
        Entries entries = new Entries();
        DateTime theCurrentTime = DateTime.Now;

        int numberResponse;

        do
        {
            Console.WriteLine("Please select one of the following choices");

            menu.DisplayMenuItems();
            menu.AskUser();

            string userResponse = Console.ReadLine();
            numberResponse = int.Parse(userResponse);

            if (numberResponse == 1)
            {
                string randomPrompt = prompt.DisplayRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write(">");

                Entry journalEntry = new Entry();
                journalEntry._prompt = randomPrompt;
                journalEntry._response = Console.ReadLine();
                journalEntry._date = theCurrentTime.ToShortDateString();

                journalEntry.CreateEntry();
                entries.AddEntryToList(journalEntry);
            }

            else if (numberResponse == 2)
            {
                entries.Display();

            }

            else if (numberResponse == 3)
            {
                entries.ReadFromFile();
            }

            else if (numberResponse == 4)
            {
                entries.SaveToFile(entries._entries);
            }

        } while (numberResponse != 5);

    }
}