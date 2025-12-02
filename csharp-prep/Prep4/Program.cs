using System;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        int average = 0;
        int largest = 0;
        int least = 0;
        Console.WriteLine("Enter a list of Numbers, and type 0 when finished");
        int input = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        numbers.Add(input);
        while (input != 0)
        {
            Console.WriteLine("Enter a list of Numbers, and type 0 when finished");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }
        foreach (int nums in numbers)
        {
            total = total + nums;
            if (nums > largest) largest = nums;
            if (nums < least) least = nums;
        }
        average = total / numbers.Count;
        Console.WriteLine($"The Sum is: {total} \n The average is {average} \n The largest number is: {largest} \n The smallest number is {least} ");
    }
}