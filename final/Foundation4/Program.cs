// File: Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Program 4: Polymorphism with Exercise Tracking ---");

        Running run = new Running("03 Nov 2022", 30, 3.0);
        Cycling bike = new Cycling("04 Nov 2022", 45, 15.5);
        Swimming swim = new Swimming("05 Nov 2022", 20, 20);

        List<Activity> activities = new List<Activity>();
        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}