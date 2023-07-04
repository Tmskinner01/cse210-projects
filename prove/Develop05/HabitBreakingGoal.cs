public class HabbitBreakingGoal : Goal
{

    public HabbitBreakingGoal(string name) : base(name)
    {
        _points = -50;
        _stringRepresentation = $"HabitBreakingGoal:{_name}";

    }
    public override int RecordEvent()
    {
        return _points;
    }
}