using System; 
public class SensationActivity : Activity
{
    public SensationActivity()
    {
        _name = "Sensation";
        _description = "This activity is designed to help you become aware of sensations in your physical body. Clear your mind and feel a tingling sensation move throughout your body.";
        
        prompts.Add("head");
        prompts.Add("legs");
        prompts.Add("arms");
        prompts.Add("fingers");
        prompts.Add("chest");
        prompts.Add("ears");
        prompts.Add("back");
        prompts.Add("feet");
        prompts.Add("knees");
    }
    public void MoveSensation()
    {
        Console.Write($"Good, now feel the sensation move into your {GeneratePrompt()}");
        PauseSpinner(6);
        Console.WriteLine();
        Console.WriteLine();
    }
}