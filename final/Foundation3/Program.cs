// File: Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Lecture lectureEvent = new Lecture(
            "The Future of AI", 
            "An insightful look into machine learning.", 
            "August 12, 2025", 
            "10:00 AM", 
            "123 Education Ln, Boston, MA", 
            "Dr. Alan Turing", 
            150
        );

        Reception receptionEvent = new Reception(
            "Tech Gala 2025", 
            "A formal evening for networking.", 
            "September 5, 2025", 
            "7:00 PM", 
            "456 Social Cir, Chicago, IL", 
            "events@techgala.com"
        );

        OutdoorGathering outdoorEvent = new OutdoorGathering(
            "Summer Festival", 
            "Music, food, and fun in the sun.", 
            "July 20, 2025", 
            "12:00 PM", 
            "789 Nature Blvd, Denver, CO", 
            "Sunny with a light breeze"
        );

        // 2. Put events in a list
        List<Event> events = new List<Event>();
        events.Add(lectureEvent);
        events.Add(receptionEvent);
        events.Add(outdoorEvent);

        // 3. Display all message types
        foreach (Event ev in events)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("SHORT DESCRIPTION:");
            Console.WriteLine(ev.GetShortDescription());
            
            Console.WriteLine("\nSTANDARD DETAILS:");
            Console.WriteLine(ev.GetStandardDetails());

            Console.WriteLine("\nFULL DETAILS:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}