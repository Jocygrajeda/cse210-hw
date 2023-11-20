using System;
using System.Collections.Generic;

public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;

    public static void Main()
    {
        while (true)
        {
            DisplayMenuOptions();

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    DisplayGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Thank you for putting in your goals :)");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void DisplayMenuOptions()
    {
        Console.Clear();
        Console.WriteLine($"Current Score: {score}");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals ");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Events");
        Console.WriteLine("  6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }

    public static void DisplayGoals()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.DisplayGoal());
        }
    }

    public static void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine(" 1. Simple goal");
        Console.WriteLine(" 2. Eternal goal");
        Console.WriteLine(" 3. Checklist goal");
        Console.WriteLine("What type of goal do you want to create?");
        string input = Console.ReadLine();

        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();

        Console.WriteLine("Provide a short description for the goal:");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        if (!int.TryParse(Console.ReadLine(), out int pointValue))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        switch (input)
        {
            case "1":
                goals.Add(new SimpleGoal(name, pointValue, description));
                break;
            case "2":
                goals.Add(new EternalGoal(name, pointValue, description));
                break;
            case "3":
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                if (!int.TryParse(Console.ReadLine(), out int numTimes))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                goals.Add(new ChecklistGoal(name, pointValue, numTimes));
                break;
            default:
                Console.WriteLine("Invalid input. Please try again.");
                break;
        }
    }

    public static void RecordEvent()
    {

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available to record events. Create goals first.");
            return;
        }

        Console.Clear();
        Console.WriteLine("Which goal did you accomplish?");
        int i = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{i}. {goal.DisplayGoal()}");
            i++;
        }
        
        if (!int.TryParse(Console.ReadLine(), out int selection) || selection < 1 || selection > goals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Goal selectedGoal = goals[selection - 1];

        if (selectedGoal is SimpleGoal simpleGoal)
        {
            int pointsEarned = simpleGoal.MarkCompleted();
    
            if (pointsEarned > 0)
            {
                score += pointsEarned;
                Console.WriteLine($"Congratulations! You earned {pointsEarned} points for completing {simpleGoal.Name}.");
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }
        else if (selectedGoal is EternalGoal)
        {
            score += selectedGoal.CalculatePoints();
            Console.WriteLine($"Congratulations! You earned {selectedGoal.PointValue} points for recording {selectedGoal.Name}.");
        }
        else if (selectedGoal is ChecklistGoal checklistGoal)
        {
            if (!checklistGoal.IsCompleted())
            {
                checklistGoal.RecordProgress();
                score += checklistGoal.CalculatePoints();
                Console.WriteLine($"Congratulations! You earned {checklistGoal.PointValue} points for recording progress on {checklistGoal.Name}.");
                if (checklistGoal.IsCompleted())
                {
                    Console.WriteLine($"You earned a bonus of {checklistGoal.PointValue} points for completing {checklistGoal.Name}.");
                }
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }
    }

    public static void DisplayScore()
    {
        Console.WriteLine($"Your score is {score}.");
    }

    public static void SaveGoals()
    {
        GoalFileManager.SaveGoals(goals);
        Console.WriteLine("Goals and scores have been saved.");
    }

    public static void LoadGoals()
    {
        List<Goal> loadedGoals = GoalFileManager.LoadGoals();
        goals.AddRange(loadedGoals);
        Console.WriteLine("Goals and scores have been loaded.");
    }
}