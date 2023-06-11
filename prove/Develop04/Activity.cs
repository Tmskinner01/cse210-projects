using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> prompts = new List<string>();
    protected int SetDuration()
    {   
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationInput = Console.ReadLine();
        int duration = int.Parse(durationInput);
        _duration = duration;
        return  _duration;
    }
    public int GetDuration()
    {
        int duration = _duration;
        return duration;
    }
    public int DisplayStart()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        _duration = SetDuration();
        
        // clear console and "load" activity
        Console.Clear();
        Console.WriteLine("Get Ready...");
        PauseSpinner(3);
        Console.WriteLine();

        return _duration;
        
    }
    public void DisplayEnd()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        PauseSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        Console.WriteLine();
        PauseSpinner(3);
    }
    public void PauseSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
           string s = animationStrings[i];
           Console.Write(s);
           Thread.Sleep(50);
           Console.Write("\b \b");
           
           i++;
           if (i>= animationStrings.Count)
           {
                i = 0;
           }
        }
    }
    public void PauseTimer(int seconds)
    {
        for(int i = seconds; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
    }
    public string RandomSelection(List<string> list)
    {
        Random random = new Random();
        var index = random.Next(list.Count);
        var randomItem = list[index];
        return randomItem;
    }
    public string GeneratePrompt()
    {
        string randomPrompt = RandomSelection(prompts);
        return randomPrompt;
    }
}