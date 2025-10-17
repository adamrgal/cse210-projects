using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Journal. The corrected empty constructor makes this clean.
        Journal myJournal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Load the Journal from a File");
            Console.WriteLine("4. Save the Journal to a File");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(myJournal);
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.Write("Enter the filename to save: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    return; // Exits the program

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Helper method to handle the logic for creating a new entry
    public static void WriteNewEntry(Journal journal)
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        string randomPrompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine($"\nPrompt: {randomPrompt}");
        Console.Write("> ");
        string entryText = Console.ReadLine();

        Console.Write("What is your current mood? ");
        string mood = Console.ReadLine();
        Console.Write("Where are you right now? ");
        string location = Console.ReadLine();

        string dateText = DateTime.Now.ToShortDateString();

        // Create the new Entry object
        Entry newEntry = new Entry(dateText, randomPrompt, entryText, mood, location);

        // Use the AddEntry method from the Journal class
        journal.AddEntry(newEntry);
        Console.WriteLine("Entry saved!");
    }
}