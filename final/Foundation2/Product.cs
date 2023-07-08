public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private double _quantity;
    public Product(string name, string productID, double price, double quantity)
    {
        _name = name;
        _productId = productID;
        _quantity = quantity;
        _price = price * quantity;
    }
    public void Display()
    {
        Console.WriteLine($"Product: {_name}, Product ID: {_productId}, Price: ${_price:0.00}, Quantity: {_quantity}");
    }
    public double GetPrice()
    {
        return _price;
    }
}