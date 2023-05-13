using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "If I could do one thing differently today, what would it be?",
        "What made today stick out?",
        "What is one thing I'm grateful for today?",
        "How am I feeling? Why do I feel that way?"
    };
    public string DateAndPrompt()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        var random = new Random();
        int index = random.Next(_prompts.Count);
        string fullPrompt = ($"Date: {dateText} - {_prompts[index]}");
        return fullPrompt;

    }
}