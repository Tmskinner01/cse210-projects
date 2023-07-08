public class Customer
{
    private string _name;
    private string _address;
    private bool _inUsa;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address.GetFullAddress();
        _inUsa = address.GetUsaBool();
    }
    public bool GetUsaBool()
    {
        return _inUsa;
    }
    public void Display()
    {
        Console.WriteLine($"Customer: {_name}");
        Console.WriteLine($"Address: {_address}");
    }

}