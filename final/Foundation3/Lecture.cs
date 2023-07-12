public class Lecture : Event
{
    private string _speaker;
    private string _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string capacity, string speaker) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }
    public override void GetFullDetatails()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        GetStandardDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}