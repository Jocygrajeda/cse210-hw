using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        int choice;
        string input;
        while (loop)
        {
            input = GetMenuChoice();

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        BreathingActivity bActivity = new BreathingActivity();
                        bActivity.Start();
                        break;
                    case 2:
                        Console.Clear();
                        ReflectionActivity rActivity = new ReflectionActivity();
                        rActivity.Start();
                        break;
                    case 3:
                        Console.Clear();
                        ListingActivity lActivity = new ListingActivity();
                        lActivity.Start();
                        break;
                    case 4:
                        Console.Clear();
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
            else
            {
                Console.Clear();
            }
        }
    }

    static string GetMenuChoice()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Breathing Activity");
        Console.WriteLine("  2. Reflection Activity");
        Console.WriteLine("  3. Listing Activity");
        Console.WriteLine("  4. Quit");

        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        return choice;
    }

    static int GetDuration()
    {
        int duration;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {
                return duration;
            }
            Console.WriteLine("Invalid input. Please enter a positive integer value.");
        }
    }
}
