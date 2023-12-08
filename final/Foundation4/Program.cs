using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity> //list to store diff activities
        {
           //diff activity types
            new Running(DateTime.Now, 30, 3.0),
            new Cycling(DateTime.Now.AddDays(1), 45, 25.0),
            new Swimming(DateTime.Now.AddDays(2), 40, 20)
        };

        foreach (Activity activity in activities)//iterate through the list and display the summary for each activity
        {
            Console.WriteLine(activity.GetSummary());//display summary
            Console.WriteLine();
        }
    }
}
