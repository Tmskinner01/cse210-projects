using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string _text = "Hello There!";
        Console.WriteLine(_text);
        _text = Regex.Replace(_text, "[a-z]", "_");
        _text = Regex.Replace(_text, "[A-z]", "_");
        Console.WriteLine(_text);

    }
}