
using System;

class Program
{
    static void Main()
    {

        string[] scriptureFiles = {
            "john.txt",
            "proverbs.txt",
            "proverbs2.txt",
            "matthew9.txt"
            //to add files
        };

     foreach (var filePath in scriptureFiles)
        {
            // load scripture from file
            Scripture scripture = Scripture.LoadFromFile(filePath);

            if (scripture != null)
            {
                // hiding words until all words are hidden
                while (!scripture.AllWordsHidden)
                {
                    scripture.ClearConsole();
                    scripture.Display();

                    Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                    string userInput = Console.ReadLine().ToLower();

                    if (userInput == "quit")
                        break;

                    scripture.HideRandomWord();
                }
            }
            else
            {
                Console.WriteLine($"Failed to load scripture from file: {filePath}");
            }
        }
    }
}
