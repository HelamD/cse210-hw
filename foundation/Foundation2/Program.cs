using System;

class Program
{
    static void Main(string[] args)
    {
    Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Create an order for Customer 1
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 1200.00, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25.00, 2));

        // Display details for order 1
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}\n");

        // Create an address for Customer 2 (lives outside the USA)
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create an order for Customer 2
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "T789", 400.00, 1));
        order2.AddProduct(new Product("Keyboard", "K321", 50.00, 1));

        // Display details for order 2
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
    }
}