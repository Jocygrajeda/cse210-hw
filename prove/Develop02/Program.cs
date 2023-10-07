//statements
using System;
using System.Collections.Generic;
//C# knows where to find the StreamWriter class
using System.IO;

class Program
{
    //main method
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        //control program execution
        bool isRunning = true;
        while (isRunning)
        {
            //menu
            Console.WriteLine(); 
            Console.WriteLine("Welcome to Journal Program!!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine(); 

            //user input
            Console.Write("What would you like to do? ");
            int choice;
            //input validation loop
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice :()");
            }

            //statement according to the user choice
            switch (choice)
            {
                case 1:
                    journal.WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.LoadJournal();
                    break;
                case 4:
                    journal.SaveJournal();
                    break;
                case 5:
                    isRunning = false;
                    break;  
                default:
                    Console.WriteLine("Please select between 1-5");
                    break;
            }
        }
    }
}

class Entry
{

    //properties for the entry class
    public string Question { get; set; }
    public string Answer { get; set; }
    public DateTime Date { get; set; }

    //constructor
    public Entry(string question, string answer, DateTime date)
    {
        Question = question;
        Answer = answer;
        Date = date;
    }
}

class Journal
{

    //list to store entries to the journal
    private List<Entry> entries;

    //constructor
    public Journal()
    {
        entries = new List<Entry>();
    }

    public void WriteNewEntry()
    {
       //list of prompts for the user
        List<string> questions = new List<string>
        {
            "What inspired you today, and how did it impact your mindset?",
            "Did you step out of your comfort zone today? If so, how did it feel?",
            "What new ideas or perspectives did you encounter today?",
            "In what ways did you practice self-care or mindfulness today?",
            "Describe a moment today that challenged your thinking or assumptions.",
            "Did you make progress on any long-term goals today? If yes, what steps did you take?",
            "How did you contribute to the well-being of others today?",
            "What skills or knowledge did you enhance or acquire today?",
            "Reflect on a decision you made today. What factors influenced your choice?",
            "Share a moment when you felt a sense of accomplishment or pride.",
            "Did you eat breakfast today?"
        };

        //random initialization
        Random random = new Random();
        int index = random.Next(questions.Count);
        string question = questions[index];

        //display a question, from the prompt
        Console.WriteLine(question);
        //user input, prompt answer
        string answer = Console.ReadLine();

        //This line creates a new Entry object with the selected question, the user's answer, and the current date and time
        Entry entry = new Entry(question, answer, DateTime.Now);
        //adding entry to the journal
        entries.Add(entry);

        Console.WriteLine(); 
        Console.WriteLine("Entry added successfully.");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("The Journal is empty.");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                //display entry with date, question, and anwser
                Console.WriteLine($"{entry.Date} - {entry.Question}: {entry.Answer}");
                Console.WriteLine(); 
            }
        }
    }

    public void SaveJournal()
    {
        //userinput for file name
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        Console.WriteLine(); 

        try
        {
            //use StreamWriter to write entries to the file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entry entry in entries)
                {
                    //csv format
                    Console.WriteLine(); 
                    writer.WriteLine($"{entry.Date},{entry.Question},{entry.Answer}");
                }
            }
            //display message
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {   //display message
            Console.WriteLine($"Error saving the diary: {ex.Message}");
        }
    }

    public void LoadJournal()
    {   //user input
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        Console.WriteLine(); 
        try
        {
            //use StreamReader to read the entries
            using (StreamReader reader = new StreamReader(fileName))
            {
                //clear existing entries
                entries.Clear();

                //read each line from the file
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into parts using |,| as a delimiter
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string dateStr = parts[0];
                        string question = parts[1];
                        string answer = parts[2];

                        DateTime date = DateTime.Parse(dateStr);
                        Entry entry = new Entry(question, answer, date);
                        entries.Add(entry);
                    }
                }
            }
            //display message
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            //display message
            Console.WriteLine($"Error loading the Journal: {ex.Message}");
        }
    }
}
