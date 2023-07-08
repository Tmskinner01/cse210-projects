public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _inUsa;
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
        if (country == "US")
        {
            _inUsa = true;
        }
        else
        {
            _inUsa = false;
        }
    }
    public bool GetUsaBool()
    {
        return _inUsa;
    }
    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}