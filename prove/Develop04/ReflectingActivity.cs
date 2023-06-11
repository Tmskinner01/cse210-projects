using System;

public class ReflectingActivity : Activity
{
    protected List<string> reflectionQuestions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        // set prompts
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        // set reflection questions
        reflectionQuestions.Add("Why was this experience meaningful to you?");
        reflectionQuestions.Add("Have you ever done anything like this before?");
        reflectionQuestions.Add("How did you get started?");
        reflectionQuestions.Add("How did you feel when it was complete?");
        reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        reflectionQuestions.Add("What is your favorite thing about this experience?");
        reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        reflectionQuestions.Add("What did you learn about yourself through this experience?");
        reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    }
    public string GenerateQuestion()
    {
        string randomQuestion = RandomSelection(reflectionQuestions);
        return randomQuestion;
    }
}