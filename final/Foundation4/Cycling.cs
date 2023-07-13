public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
        _activityName = "Cycling";
    }
    protected override double GetDistance()
    {
        double distance = (_speed / 60) * _length;
        return distance;
    }
    protected override double GetSpeed()
    {
        return _speed;
    }
    protected override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }

}