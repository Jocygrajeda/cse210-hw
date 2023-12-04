
using System;

class Program
{
    static void Main(string[] args)
    {
        int menu;

        //main menu loop
        do
        {
            Console.Clear();
            DisplayMenu();

            //get user input and validate
            if (!int.TryParse(Console.ReadLine(), out menu))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                WaitForUserInput();
                continue;
            }

            //execute the chosen number
            switch (menu)
            {
                case 1:
                    ExecuteActivity(new Breathing(10, "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing", 5, 5, "", 5, 5));
                    break;
                case 2:
                    ExecuteActivity(new Reflection(10, "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection", 5, 5, ""));
                    break;
                case 3:
                    ExecuteActivity(new Listing(10, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing", 5, 5, ""));
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    WaitForUserInput();
                    break;
            }
        } while (menu != 4);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("╔══════════════════════════╗");
        Console.WriteLine("║      Menu Options        ║");
        Console.WriteLine("╠══════════════════════════╣");
        Console.WriteLine("║  1. Breathing Activity   ║");
        Console.WriteLine("║  2. Reflection Activity  ║");
        Console.WriteLine("║  3. Listing Activity     ║");
        Console.WriteLine("║  4. Quit                 ║");
        Console.WriteLine("╚══════════════════════════╝");
        Console.Write("Select a choice from the menu: ");
    }

    static void WaitForUserInput()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void ExecuteActivity(Activity activity)
    {
        activity.StartActivity();
        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
    }
}

