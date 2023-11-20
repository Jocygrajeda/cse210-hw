using System;
using System.IO;

//GoalManager class manages the creation, listing, saving, loading, and recording events for goals
public class GoalManager
{

    private List<Goal> _goals; //list to store created goals

    private int _score; //score from completed goals

public GoalManager()
{
    _goals = new List<Goal>();
    _score = 0;
}

public void Start()
{
    //displaying menu, options 
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"\nYou have {_score} points....");
    Console.WriteLine();
    Console.WriteLine("Menu options: ");
    Console.WriteLine("  1. Create New Goal");
    Console.WriteLine("  2. List Goals");
    Console.WriteLine("  3. Save Goals");
    Console.WriteLine("  4. Load Goals");
    Console.WriteLine("  5. Record Event");
    Console.WriteLine("  6. Quit");
    Console.Write("Select a choice from menu: ");
    Console.ResetColor();
    Console.WriteLine();

}

//user input for goals
public void CreateGoaL()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The types of Goals are: ");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. ChecklistGoal");
    Console.Write("\nWhich type of goal would you like to create? ");

    string goal = Console.ReadLine();
    Console.Write("What is the name of your goal? "); 
    string name = Console.ReadLine();
    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();
    Console.WriteLine("What is the amount of points associated with this goal? ");
    string points = Console.ReadLine();

    if (goal == "1")
    {
        
        SimpleGoal simple = new SimpleGoal(name, description, points);

        _goals.Add(simple);    

    } else if (goal == "2") 
    {
         EternalGoal simple = new EternalGoal(name, description, points);

        _goals.Add(simple);    

    }  else if (goal == "3") 
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());
        Console.ResetColor();
        ChecklistGoal simple = new ChecklistGoal(name, description, points, target, bonus);
        _goals.Add(simple);

    } else 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("error, please try again.");
        Console.ResetColor();
    }

    

}

public void ListGoalsNames()
{
    int count = 1;
     Console.WriteLine("\nThe goals are: ");
    foreach (Goal name in _goals)
    {
        Console.WriteLine($"{count}. {name.GetName()}");
        count++;
    }
}

public void ListGoalsDetails() 
{
    int count = 1;

    Console.WriteLine("The goals are: ");

    foreach (Goal goal in _goals) 
    {
        Console.WriteLine($"{count}. {goal.GetDetailsString()}");
        count++;
    }
}

public void SaveGoals() //save goals to a file, i have goals.txt 
{
    Console.Write("What is the filename for the goal file? ");
    string fileName= Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(fileName)) 
    {
        outputFile.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
    }
}

public void LoadGoals() //load goal from a file
{
    Console.Write("What is the filename for the goal file? ");
    string file = Console.ReadLine();
    string[] lines = System.IO.File.ReadAllLines(file);

     _score = int.Parse(lines.First());

    string[] text = lines.Skip(1).ToArray();
    

    foreach(string line in text)
    {
        

               
        string[] parts = line.Split(":");

        string goalType = parts[0];

        string details = parts[1];

        string[] part = details.Split(",");

        if (goalType == "SimpleGoal")
        {
            SimpleGoal simplePart = new SimpleGoal(part[0], part[1], part[2]);

            _goals.Add(simplePart);
            
        } else if (goalType == "EternalGoal")
        {
            EternalGoal eternalPart = new EternalGoal(part[0], part[1], part[2]);
                
            _goals.Add(eternalPart);

        } else if (goalType == "ChecklistGoal")
        {
            ChecklistGoal checklistPart = new ChecklistGoal(part[0], part[1], part[2], int.Parse(part[4]), int.Parse(part[3]));
            checklistPart.SetAmount(int.Parse(part[5]));

            _goals.Add(checklistPart);
        }

        } 
    }


public void RecordEvent()
{
    ListGoalsNames();
    Console.WriteLine("Which goal did you accomplish? ");
    int goalCompleted = int.Parse(Console.ReadLine());

    _goals[goalCompleted - 1].RecordEvent();

    int earnedPoints = _goals[goalCompleted - 1].GetPoints();

    _score += earnedPoints; 

    Console.WriteLine($"\nYou have earned {earnedPoints} points!!!");

    Console.WriteLine($"You now have {_score} points.");
}

}