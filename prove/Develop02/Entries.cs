using System.IO;
public class Entries


{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntryToList(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry ent in _entries)
        {
            Console.WriteLine(ent.CreateEntry());
            Console.WriteLine();
        }
    }

    public void SaveToFile(List<Entry> entries)
    {
        Console.Write("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine(e.CreateEntry());
            }
        }
    }

    public List<Entry> ReadFromFile()
    {
        Console.Write("What is the Filename? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        return _entries;
    }



}
