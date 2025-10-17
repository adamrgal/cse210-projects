// File: Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Testing Constructors ---");

        // Create a fraction using the no-argument constructor (defaults to 1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Create a fraction for 5 (or 5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        
        // Create a fraction for 3/4
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
        // Create a fraction for 1/3
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Console.WriteLine("\n--- Testing Getters and Setters ---");
        
        // Use setters to change the values of f1
        f1.SetTop(2);
        f1.SetBottom(5);

        // Use getters to retrieve and display the new values
        Console.WriteLine($"New Top: {f1.GetTop()}");
        Console.WriteLine($"New Bottom: {f1.GetBottom()}");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
    }
}