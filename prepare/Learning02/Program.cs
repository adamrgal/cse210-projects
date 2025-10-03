using System;
using System.Runtime.InteropServices;




class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job("Google", "Youtuber", 2023, 2025);
        Job job2 = new Job("Mr.Pickles", "Sandwich Artist", 2021, 2025);
        job1.Display();
        List<Job> job_list = new List<Job>();
        job_list.Add(job1);
        job_list.Add(job2);

        Resume resume1 = new Resume("Adam", job_list);
        resume1.Display();
    }
}