using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Mosiah", 2, 17);
        Scripture scripture = new Scripture(reference, "Behold, I tell you this things that ye may learn wisdom. That when ye are in the service of your fellow beings, ye are only in the service of your God.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.Write($"{scripture.Reference} - ");
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("Press enter to hide a word, or type 'quit' to exit");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                return;
            }
            else
            {
                scripture.HideWords(1);
            }
        }

        Console.Clear();
        Console.WriteLine("All the words are completely hidden.");
        Console.WriteLine(scripture.GetRenderedText());
    }
}