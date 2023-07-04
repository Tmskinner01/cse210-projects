public class Goal // This base class will be used as the Simple Goal as well. 
{
    protected string _name;
    protected int _points;
    protected bool _goalComplete;
    protected string _stringRepresentation;

    public Goal(string name)
    {
        _name = name;
        _points = 100;
        _stringRepresentation = $"Goal:{_name}";
    }
    public virtual int RecordEvent()
    {   
        IsComplete();
        return _points;
    }
    public void IsComplete()
    {
        _goalComplete = true;
    }
    public bool CheckCompletion()
    {
        return _goalComplete;
    }
    public virtual void DisplayGoal()
    {   
        if (_goalComplete)
        {
            Console.WriteLine($"[X] {_name} (Points: {_points})");
        }
        else if (_goalComplete == false)
        {
            Console.WriteLine($"[ ] {_name} (Points: {_points})");
        }
    }
    public string GetStringRepresentation()
    {   
        return _stringRepresentation;
    }
}
