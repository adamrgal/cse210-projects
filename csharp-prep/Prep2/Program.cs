using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter your percentage");
        int percentage = int.Parse(Console.ReadLine());
        string letter_grade = "z";
        bool pass_fail
        if (percentage >= 90)
        {
            letter_grade = "A";
            pass_fail = true;
        }
        if (percentage >= 80 && percentage < 90)
        {
            letter_grade = "B";
            pass_fail = true;
        }
        if (percentage >= 70 && percentage < 80)
        {
            letter_grade = "C";
            pass_fail = true;
        }
        if (percentage >= 60 && percentage < 70)
        {
            letter_grade = "D";
            pass_fail = true;
        }
        if (percentage >= 50 && percentage < 60)
        {
            letter_grade = "F";
            pass_fail = false;
        }
        else
        {
            letter_grade = "F";
            pass_fail = false;
        }
        if (pass_fail)
        {
            Console.WriteLine($"Congratulations on Passing your class your letter grade was {letter_grade}");
        }
        if (!pass_fail)
        {
            Console.WriteLine($"Better Luck Next time your letter grade was {letter_grade}");
        }
    }
}