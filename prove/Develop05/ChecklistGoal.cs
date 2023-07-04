public class ChecklistGoal : Goal
{
    protected int _bonusPoints;
    protected int _goalAmount;
    protected int _amountCompleted;
    public ChecklistGoal(string name, int goalAmount) : base(name)
    {
        _goalAmount = goalAmount;
        _points = 50;
        _bonusPoints = 150;
        _amountCompleted = 0;
        _stringRepresentation = $"ChecklistGoal:{_name}@{_goalAmount}@{_amountCompleted}";
    }
    public ChecklistGoal(string name, int goalAmount, int amountCompleted) : base(name)
    {
        _goalAmount = goalAmount;
        _points = 50;
        _bonusPoints = 150;
        _amountCompleted = amountCompleted;
        _stringRepresentation = $"ChecklistGoal:{_name}@{_goalAmount}@{_amountCompleted}";
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _goalAmount)
        {
            IsComplete();
            _points = _points + _bonusPoints;
        }
        _stringRepresentation = $"ChecklistGoal:{_name}@{_goalAmount}@{_amountCompleted}";
        return _points;
    }
    public override void DisplayGoal()
    {
         if (_goalComplete)
        {
            Console.WriteLine($"[X] {_name} (Points: {_points}, Bonus points: {_bonusPoints} ) -- Currently completed: {_amountCompleted}/{_goalAmount}");
        }
        else if (_goalComplete == false)
        {
            Console.WriteLine($"[ ] {_name} (Points: {_points}) -- Currently completed: {_amountCompleted}/{_goalAmount}");
        }
    }   
}
