using System;

class Program
{
    static void Main(string[] args)
    {
        int guess_num = -1;
        int counter = 0;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        do
        {
            Console.WriteLine("Please enter your guess");
            guess_num = int.Parse(Console.ReadLine());
            counter++;
            if (guess_num > number)
            {
                Console.WriteLine("Lower");
            }
            if (guess_num < number)
            {
                Console.WriteLine("Higher");
            }
        } while (guess_num != number);
        Console.WriteLine($"Congratulations you guessed the magic number {number} and you guessed {counter} times");
    }
}