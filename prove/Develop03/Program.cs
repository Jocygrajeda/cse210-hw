
using System;

class Program
{
    static void Main()
    {

        string[] scriptureFiles = {
            "John.txt",
            "Proverbs.txt",
            "Proverbs2.txt",
            "Matthew9.txt"
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
                    
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                    string userInput = Console.ReadLine().ToLower();

                    if (userInput == "quit")
                        break;

                    scripture.HideRandomWord(3);// how many words are hidden at a time
                }
            }
            else
            {
                Console.WriteLine($"Failed to load scripture from file: {filePath}");
            }
        }
    }
}
