using System;

class Program
{
    static void Main(string[] args)
    {
        //order 1
        Product product1 = new Product("Nuln Oil", "CS1553", 7.80, 2);
        Product product2 = new Product("Seraphim Sepia", "CS1554", 7.80, 1);
        Product product3 = new Product("Agrax Earthshade", "CS1555", 7.80, 1);

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        products1.Add(product3);

        Address address1 = new Address("1551 Settlers Lane", "New York City", "NY", "US");
        Customer customer1 = new Customer("Leah Brown", address1);

        Order order1 = new Order(customer1, products1); 
        //order 2
        Product product4 = new Product("Abbadon Black", "CB14555", 4.80, 2);
        Product product5 = new Product("Leadbelcher", "CS14556", 4.80, 1);
        Product product6 = new Product("Agrax Earthshade", "CS1555", 7.80, 1);

        List<Product> products2 = new List<Product>();
        products2.Add(product4);
        products2.Add(product5);
        products2.Add(product6);

        Address address2 = new Address("6 Cathedral Rd", "Cardiff", "South Wales", "UK");
        Customer customer2 = new Customer("James Workshop", address2);

        Order order2 = new Order(customer2, products2); 
        //display
        Console.WriteLine("Order 1:");
        order1.DisplayShippingLabel();
        order1.DisplayPackingLabel();
        order1.DisplayPrice();
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        order2.DisplayShippingLabel();
        order2.DisplayPackingLabel();
        order2.DisplayPrice();
        Console.WriteLine();

    }
}