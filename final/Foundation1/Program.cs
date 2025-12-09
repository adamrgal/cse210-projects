// File: Program.cs (YouTubeApp)
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Program 1: Abstraction with YouTube Videos ---");

        // 1. Create 3 videos
        Video video1 = new Video("C# Basics Tutorial", "CodeMaster", 900);
        Video video2 = new Video("How to make bread", "bakerdude", 1850);
        Video video3 = new Video("Fortnite victory royal", "DataWizard", 720);

        // 2. Add comments to each video
        video1.AddComment(new Comment("Alice", "Great tutorial, very clear!"));
        video1.AddComment(new Comment("Bob", "I learned so much from this video."));
        video1.AddComment(new Comment("Charlie", "Thanks for the excellent content."));

        video2.AddComment(new Comment("Diana", "The explanation of baking was perfect."));
        video2.AddComment(new Comment("Ethan", "Could you do a video on sourdough?"));
        video2.AddComment(new Comment("Fiona", "Super helpful for my project."));

        video3.AddComment(new Comment("Hannah", "Sick Dub!."));
        video3.AddComment(new Comment("Isaac", "I hope I can get a victory royale this season! "));
        video3.AddComment(new Comment("Jasmine", "Fantastic job!"));

        // 3. Put each video in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // 4. Iterate through the list and display details
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
        Console.WriteLine("------------------------------------------");
    }
}