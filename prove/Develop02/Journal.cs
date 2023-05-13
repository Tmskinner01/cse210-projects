using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {

        Entry entry = new Entry();

        PromptGenerator prompt = new PromptGenerator();
        entry._entryDateAndPrompt = prompt.DateAndPrompt();
        
        Console.Write("Please enter your name: ");
        entry._entryAuthor = Console.ReadLine();  

        Console.WriteLine(entry._entryDateAndPrompt);
        entry._entryText = Console.ReadLine();

        _entries.Add(entry);

    }
    public void Display()
    {   
        Console.WriteLine("");
        Console.WriteLine("Entries:");
        Console.WriteLine("");
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }
    public void SaveFile()
    {
        Console.WriteLine("Please enter the filename: ");
        string filename = Console.ReadLine();

        using StreamWriter outputfile = new StreamWriter(filename);
        foreach (Entry entry in _entries)
        {
            outputfile.WriteLine($"{entry._entryDateAndPrompt}@{entry._entryText}@{entry._entryAuthor}");
        }

        Console.WriteLine("File saved.");
    }
    public void LoadFile()
    {
        Console.WriteLine("Please enter the filename: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split("@");

            entry._entryDateAndPrompt = parts[0];
            entry._entryText = parts[1];
            entry._entryAuthor = parts[2];
            _entries.Add(entry);
        }
        Console.WriteLine ("File loaded successfully."); 
    }
}