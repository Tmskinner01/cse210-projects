using System;

public class BreathingActivity : Activity
{
    public void BreatheIn()
    {
        Console.Write("Breathe in...");
        PauseTimer(5);
        Console.WriteLine();
        Console.WriteLine();
    }
    public void BreatheOut()
    {
        Console.Write("Breathe out...");
        PauseTimer(5);
        Console.WriteLine();
        Console.WriteLine();
    }
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will guide you through breathing in and out to help you relax. Clear your mind and focus on breathing slowly.";
        _duration = 0;
    }
}
