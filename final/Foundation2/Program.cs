using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address nonUsaAddress = new Address("456 International St", "Cityville", "Provinceville", "Canada");

        // Create customers
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer nonUsaCustomer = new Customer("Jane Smith", nonUsaAddress);

        // Create products
        Product product1 = new Product("Laptop", "ABC123", 1200, 2);
        Product product2 = new Product("Printer", "DEF456", 300, 1);

        // Create orders
        Order order1 = new Order(new List<Product> { product1, product2 }, usaCustomer);
        Order order2 = new Order(new List<Product> { product2 }, nonUsaCustomer);

        // Display results
        DisplayOrderInformation(order1, "Order 1");
        DisplayOrderInformation(order2, "Order 2");
    }

    static void DisplayOrderInformation(Order order, string orderName)
    {
        Console.WriteLine($"{orderName} - Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine($"{orderName} - Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"{orderName} - Total Price: ${order.CalculateTotalPrice()}");
        Console.WriteLine("\n----------------------\n");
    }
}
