public class Reception : Event
{
    private string _RSVP;
    public Reception(string title, string description, string date, string time, Address address, string RSVP) : base(title, description, date, time, address)
    {
        _RSVP = RSVP;
        _eventType = "Reception";
    }
    public override void GetFullDetatails()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        GetStandardDetails();
        Console.WriteLine($"RSVP at: {_RSVP}");
    }
}