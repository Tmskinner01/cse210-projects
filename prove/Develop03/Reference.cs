using System;

public class Reference
{
    private int _chapter;
    private string _book;
    private int _verseNumber;
    private int _endVerseNumber;
    public Reference(string book, int chapter, int verseNumber)
    {
        _book = book;
        _chapter = chapter;
        _verseNumber = verseNumber;
        _endVerseNumber = -1;    
    }
     private Reference(string book, int chapter, int verseNumber, int endVerseNumber)
    {
        _book = book;
        _chapter = chapter;
        _verseNumber = verseNumber;
        _endVerseNumber = endVerseNumber;
    }
    public string GetReference()
    {
        if(_endVerseNumber == -1)
        {
            return ($"{_book} {_chapter}:{_verseNumber}");
        }
        else return ($"{_book} {_chapter}:{_verseNumber}-{_endVerseNumber}");
    }
}