public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _totalPrice;
    private double _subtotal;
    private double _shippingCost;
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
        if (_customer.GetUsaBool() == true)
        {
            _shippingCost = 5;
        }
        else if (_customer.GetUsaBool() == false)
        {
            _shippingCost = 35;
        }
        _subtotal = 0;
        foreach (Product product in _products)
        {
            _subtotal = product.GetPrice() + _subtotal;
        }
        _totalPrice = _shippingCost + _subtotal;
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label: ");
        foreach (Product product in _products)
        {
            product.Display();
        }
        Console.WriteLine();
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label: ");
        _customer.Display();
        Console.WriteLine();
    }
    public void DisplayPrice()
    {
        Console.WriteLine($"Subtotal: ${_subtotal:0.00}");
        Console.WriteLine($"Shipping: ${_shippingCost:0.00}");
        Console.WriteLine($"Total: ${_totalPrice:0.00}");
    }
}