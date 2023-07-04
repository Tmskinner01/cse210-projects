public class FileSlot
{
    protected List<Goal> _goals = new List<Goal>();
    protected int _totalPoints;
    public FileSlot(List<Goal> goalList)
    {
        _goals = goalList;
    }
    public FileSlot()
    {

    }
    public void SaveFile(string filename, int pointTotal)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {   
            outputFile.WriteLine(pointTotal);
            foreach (Goal goal in _goals)
            {
            string stringForm = goal.GetStringRepresentation();
            bool isComplete = goal.CheckCompletion();
            if (isComplete)
            {
                outputFile.WriteLine($"{stringForm}:True");
            }
            else 
            {
                outputFile.WriteLine($"{stringForm}:False");
            }
            }
        }
    }
    public int LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        int totalPoints = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string newStringForm = parts[1];
            string boolStatus = parts[2];

            // create new goal object using info
            if (goalType == "Goal")
            {
                Goal goal = new Goal(newStringForm);
                _goals.Add(goal);
                if (boolStatus == "True")
                {
                    goal.IsComplete();
                }
            }
            else if (goalType == "ChecklistGoal")
            {
                string[] goalParts = newStringForm.Split("@");
                string name = goalParts[0];
                int goalAmount = int.Parse(goalParts[1]);
                int amountCompleted = int.Parse(goalParts[2]);

                ChecklistGoal checklistGoal = new ChecklistGoal(name, goalAmount, amountCompleted);
                _goals.Add(checklistGoal);

                if (boolStatus == "True")
                {
                    checklistGoal.IsComplete();
                }
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(newStringForm);
                _goals.Add(eternalGoal);

                if (boolStatus == "True")
                {
                    eternalGoal.IsComplete();
                }
            }
            else if (goalType == "HabitBreakingGoal")
            {
                HabbitBreakingGoal habbitBreakingGoal = new HabbitBreakingGoal(newStringForm);
                _goals.Add(habbitBreakingGoal);

                if (boolStatus == "True")
                {
                    habbitBreakingGoal.IsComplete();
                }
            }
        }
        return totalPoints;
    }
    public List<Goal> GetGoalList()
    {
        return _goals;
    }
}