using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
    
    bool replay = true;

    
    GoalManager game = new GoalManager();
    

    //main loop for the app.
    while (replay)
    
    {
      //display the menu
       game.Start();

        //read users choice
       string choice = Console.ReadLine();

        //user input
        if (choice == "1")
        {
            game.CreateGoaL();

        } else if (choice == "2")
        {
            game.ListGoalsDetails();

        } else if (choice == "3") 
        {
            game.SaveGoals();

        } else if (choice =="4")
        {

            game.LoadGoals();

        } else if (choice == "5") 
        {

            game.RecordEvent();


        } else if (choice == "6")//exit app.
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Thank you, see ya!!");
            Console.ResetColor();
            replay = false;
            
        }
    

    }
    
    }
}

//added color to the text in the terminal to be a little more visually appealing