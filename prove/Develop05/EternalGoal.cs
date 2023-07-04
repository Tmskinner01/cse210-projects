public class EternalGoal: Goal
{
    public EternalGoal(string name) : base(name)
    {
        _points = 20;
        _stringRepresentation = $"EternalGoal:{_name}";
    }
    public override int RecordEvent()
    {
        return _points;
    }
}