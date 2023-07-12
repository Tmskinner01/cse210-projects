public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
        _eventType = "Outdoor Gathering";
    }
    public override void GetFullDetatails()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        GetStandardDetails();
        Console.WriteLine($"Weather Forecast: {_weather}");
    }
}