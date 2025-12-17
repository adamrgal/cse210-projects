using System;
using System.IO;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "Users/adamgaloul/Downloads/downloads/bookofmormon.txt"; 

            try
            {
                // Instantiate the library, which attempts to load scriptures from the file
                ScriptureLibrary library = new ScriptureLibrary(filename);
                Scripture scripture = library.GetRandomScripture();

                string userInput = "";
                Console.Clear();
                Console.WriteLine("Welcome to the Scripture Memorizer! Press Enter to begin.");
                Console.ReadLine();


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
                Console.WriteLine($"Error: The '{filename}' file was not found.");
                Console.WriteLine("Please check the file path and make sure the file exists in the program's execution directory.");
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