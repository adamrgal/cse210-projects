using System;
using System.Collections;

class Program
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    public static string PromptUserName()
    {
        Console.WriteLine("Please enter a Username");
        string name = Console.ReadLine();
        return name;
    }
    public static int PromptUserNumber()
    {
         Console.WriteLine("Please enter your favorite number ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    public static void PromptUserBirthYear(out int birthyear)
    {
        Console.WriteLine("Please enter your Birth Year");
        birthyear = int.Parse(Console.ReadLine());
    }
    public static int SquareNumber(int num)
    {
        int sqrt = (int)Math.Sqrt(num);
        return sqrt; 
    }
    public static void DisplayResults(string username, int sqrt, int birthyear)
    {
        Console.WriteLine($"{username}, the square of your number is {sqrt} \n {username} this year you will turn {2025 - birthyear}");
    }
    static void Main(string[] arg)
    {
        WelcomeMessage();
        int birthyear;
        PromptUserBirthYear(out birthyear);
        Console.WriteLine("Please enter another numeber");
        SquareNumber(int.Parse(Console.ReadLine()));
        DisplayResults(PromptUserName(), SquareNumber(int.Parse(Console.ReadLine())), birthyear);
    }
}