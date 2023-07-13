public class Running : Activity
{
    private double _distance;
    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
        _activityName = "Running";
    
    }
    protected override double GetDistance()
    {
        return _distance;
    }
    protected override double GetSpeed()
    {
        double speed = (_distance / _length) * 60;
        return speed;
    }
    protected override double GetPace()
    {
        double pace = _length / _distance;
        return pace;
    }

}