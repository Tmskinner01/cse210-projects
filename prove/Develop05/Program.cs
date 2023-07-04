using System;

class Program
{
    static void Main(string[] args)
    {   
        //Declare starting variables
        int totalPoints = 0;
        string menuInput = "0";
        List<Goal> goals = new();

       //Print menu text
        do
        {
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit ");
            Console.Write("Select a choice from the menu: ");

            menuInput = Console.ReadLine();
            Console.WriteLine();

            if (menuInput == "1")
            {
                // present goal types
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("  4. Habit Breaking Goal");
                Console.Write("Which type of goal would you like to create? ");
                //user selects goal type
                string goalType = Console.ReadLine();
                Console.Write("Please provide a brief name/description of your goal: ");
                string goalName = Console.ReadLine();
                //if statement tree for each goal type
                if (goalType == "1")
                {
                    Goal simpleGoal1 = new Goal(goalName);
                    goals.Add(simpleGoal1);
                }
                else if (goalType == "2")
                {
                    EternalGoal eternalGoal1 = new EternalGoal(goalName);
                    goals.Add(eternalGoal1);
                }
                else if (goalType == "3")
                {
                    Console.Write("How many times would you like to complete this goal? ");
                    string goalAmountString = Console.ReadLine();
                    Console.WriteLine();
                    int goalAmount = int.Parse(goalAmountString);

                    ChecklistGoal checklistGoal1 = new ChecklistGoal(goalName, goalAmount);
                    goals.Add(checklistGoal1);
                }
                else if (goalType == "4")
                {
                    HabbitBreakingGoal habbitBreakingGoal1 = new HabbitBreakingGoal(goalName);
                    goals.Add(habbitBreakingGoal1);
                }
            }
            else if (menuInput == "2")
            {
                Console.WriteLine("The goals are:");

                foreach (Goal goal in goals)
                {  
                    int index = goals.IndexOf(goal) + 1;
                    Console.Write($"{index}. ");
                    goal.DisplayGoal();
                }
            }
            else if (menuInput == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                Console.WriteLine();

                FileSlot fileSlot = new FileSlot(goals);
                fileSlot.SaveFile(filename, totalPoints);

                goals.Clear();
                totalPoints = 0;
            }
            else if (menuInput == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                Console.WriteLine();

                FileSlot fileSlot = new FileSlot();
                totalPoints = fileSlot.LoadFile(filename);

                goals = fileSlot.GetGoalList();
            }
            else if (menuInput == "5")
            {
                Console.WriteLine("The goals are:");

                foreach (Goal goal in goals)
                {  
                    int index = goals.IndexOf(goal) + 1;
                    Console.Write($"{index}. ");
                    goal.DisplayGoal();
                }
                Console.Write("Which goal did you accomplish? ");
                string accomplishedGoalInput = Console.ReadLine();
                int accomplishedGoalIndex = int.Parse(accomplishedGoalInput) - 1;
                
                bool goalCompleted = goals[accomplishedGoalIndex].CheckCompletion();
                if (goalCompleted == false)
                {
                    // mark goal as done and add points to total points value
                    int newPoints = goals[accomplishedGoalIndex].RecordEvent();
                    totalPoints = totalPoints + newPoints;
        
                    // display achievement message and new points value
                    if (newPoints > 0)
                    {
                        Console.WriteLine($"Congratulations! You have earned {newPoints} points!");
                    }
                    else
                    {
                        Console.WriteLine($"Your poiunts balanced has changed by {newPoints}. Keep trying and don't give up!");
                    }
                    Console.WriteLine($"You now have {totalPoints} points.");
                    Console.WriteLine();
                }
                else 
                {
                    Console.WriteLine("Please select a goal that is not already complete.");
                    Console.WriteLine();
                }
            }
        }
        while (menuInput != "6");
            
        
    }
}