using System;
using System.Collections.Generic;
using System.IO;

public static class GoalFileManager
{
    private const string FileName = "goals.txt";

    public static void SaveGoals(List<Goal> goals)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                foreach (Goal goal in goals)
                {
                    writer.WriteLine($"{goal.Name},{goal.PointValue},{goal.Description}");
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Error saving goals: {e.Message}");
        }
    }

    public static List<Goal> LoadGoals()
    {
        List<Goal> loadedGoals = new List<Goal>();

        if (File.Exists(FileName))
        {
            try
            {
                using (StreamReader reader = new StreamReader(FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            string name = parts[0];
                            int pointValue = int.Parse(parts[1]);
                            string description = parts[2];
                            loadedGoals.Add(new Goal(name, pointValue, description));
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error loading goals: {e.Message}");
            }
        }

        return loadedGoals;
    }
}
