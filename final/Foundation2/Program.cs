// File: Program.cs (OrderingApp)
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Program 2: Encapsulation with Online Ordering ---");

        // --- Order 1 (USA Customer) ---
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Laptop Charger", "LC-101", 15.50, 2)); // $31.00
        order1.AddProduct(new Product("Mouse Pad", "MP-05", 5.00, 3));     // $15.00
        // Subtotal: $46.00. Shipping (USA): $5.00. Total: $51.00

        Console.WriteLine("\n*** Order 1 Details (USA - Low Shipping) ***");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("------------------------------");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Total Order Price: **${order1.CalculateTotalCost():0.00}**");

        // --- Order 2 (International Customer) ---
        Address address2 = new Address("789 Oak Ave", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("E-book Reader", "ER-200", 89.99, 1)); // $89.99
        order2.AddProduct(new Product("Case", "CS-99", 25.00, 1));            // $25.00
        // Subtotal: $114.99. Shipping (Intl): $35.00. Total: $149.99

        Console.WriteLine("\n*** Order 2 Details (International - High Shipping) ***");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("------------------------------");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Total Order Price: **${order2.CalculateTotalCost():0.00}**");
    }
}