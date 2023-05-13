using System;

public class Entry
{
    public string _entryDateAndPrompt;
    public string _entryText;

    public string _entryAuthor;
    
    public void Display()
    {
        Console.WriteLine(_entryDateAndPrompt);
        Console.WriteLine(_entryText);
        Console.WriteLine($"-{_entryAuthor}");
    }
}