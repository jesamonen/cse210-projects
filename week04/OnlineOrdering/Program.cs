using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA Customer)

        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P101", 800, 1));
        order1.AddProduct(new Product("Mouse", "P102", 20, 2));

        // Order 2 (International Customer)

        Address address2 = new Address(
            "45 Victoria Road",
            "Lagos",
            "Lagos",
            "Nigeria");

        Customer customer2 = new Customer("Mary Johnson", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P201", 500, 1));
        order2.AddProduct(new Product("Headphones", "P202", 50, 2));
        order2.AddProduct(new Product("Charger", "P203", 25, 1));

        // Display Order 1

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n---------------------------------\n");

        // Display Order 2

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}