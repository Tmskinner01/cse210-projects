using System;

public class Scripture
{
    private string _reference;
    private bool _completelyHidden;
    private List<Word> _words = new List<Word>();
    public Scripture(string reference, string fullText)
    {
        _reference = reference;
        string[] words = fullText.Split(" ");
        foreach(var word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }  
    }
    public void GetRenderedText()
    {
        Console.Write(_reference + " ");
        foreach (var word in _words)
        {
            word.Show();
        }
        Console.WriteLine(" ");
    }
    public void HideWords()
    {
        int repeat = 2;
        for(int i = 0; i < repeat; i++)
        {
            var random = new Random();
            int index = random.Next(_words.Count);
            _words[index].IsHidden();    
        }
    }
    public void IsCompletelyHidden()
    {
        
        int hiddenCounter = 0;
        int listLength = _words.Count;
        foreach(var word in _words)
        {
            bool hiddenText = word.GetHiddenBool();
            if(hiddenText)
            {
                hiddenCounter = hiddenCounter + 1;
            }
            if (hiddenCounter == listLength)
            {
                _completelyHidden = true;
            }
        }
    }
    public bool GetHiddenBool()
    {
        return _completelyHidden;
    }
}