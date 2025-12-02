using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("What is your first name?:");
        string first_name = Console.ReadLine();
        Console.WriteLine("What is your Last name?:");
        string Last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {Last_name}, {first_name} {Last_name}");

    }
}