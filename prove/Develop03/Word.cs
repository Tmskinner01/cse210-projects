using System;
using System.Text.RegularExpressions;

public class Word
{
    private string _text;

    private bool _hiddenText;

    public Word(string text)
    {
        _text = text;
    }
    // Changes value of hiddenText bool
    public void HideWord()
    {
        _hiddenText = true;
    }
    public void Show()
    {
        Console.Write($"{_text} "); 
    }
    public void IsHidden()
    {
        if(_hiddenText == false)
        {   _text = Regex.Replace(_text, "[a-z]", "_");
            _text = Regex.Replace(_text, "[A-Z]", "_");
            HideWord();
        }

    }
    public bool GetHiddenBool()
    {
        return _hiddenText;
    }
}