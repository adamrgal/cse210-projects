using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                ScriptureLibrary library = new ScriptureLibrary("/Users/adamgaloul/Downloads/bookofmormon.txt");
                Scripture scripture = library.GetRandomScripture();

                string userInput = "";

                while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetRenderedText());
                    Console.WriteLine();

                    if (scripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("All words are hidden. Well done!");
                        break;
                    }

                    Console.Write("Press Enter to hide more words, or type 'quit' to exit: ");
                    userInput = Console.ReadLine();

                    if (userInput.ToLower() != "quit")
                    {
                        scripture.HideRandomWords(3);
                    }
                }

                Console.WriteLine("Goodbye!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The 'scriptures.txt' file was not found.");
                Console.WriteLine("Please check the file path in Program.cs and make sure the file exists.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}