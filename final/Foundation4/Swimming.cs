public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
        _activityName = "Swimming";
    
    }

    protected override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * .62;
        return distance;
    }
    protected override double GetSpeed()
    {
        double distance = _laps * 50 / 1000 * .62;
        double speed = (distance / _length) * 60;
        return speed;
    }
    protected override double GetPace()
    {
        double distance = _laps * 50 / 1000 * .62;
        double pace = _length / distance;
        return pace;
    }

}