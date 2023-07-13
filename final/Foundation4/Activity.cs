public abstract class Activity
{
    protected string _activityName;
    private string _date;
    protected double _length;
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityName}({_length} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
    protected abstract double GetDistance();
    protected abstract double GetSpeed();
    protected abstract double GetPace();
}