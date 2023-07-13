using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("12 July 2023", 30, 5);
        activities.Add(running);

        Cycling cycling = new Cycling("11 July 2023", 45, 25);
        activities.Add(cycling);

        Swimming swimming = new Swimming("04 July 2023", 30, 15);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine();
        }
    }
}