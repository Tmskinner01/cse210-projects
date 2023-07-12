public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipcode;
    public Address(string streetAdress, string city, string state, string zipcode)
    {
        _streetAddress = streetAdress;
        _city = city;
        _state = state;
        _zipcode = zipcode;
        
    }
     public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_zipcode}";
    }
}