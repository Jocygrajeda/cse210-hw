using System.ComponentModel;
using System.Reflection.Metadata;

public class Activity
{
    private string _activityName { get; set; }
    private string _description { get; set; }
    protected int _duration { get; set; }

    public Activity(string ActivityName, string Description) //, int Duration
    {
        _activityName = ActivityName;
        _description = Description;
        // _duration = Duration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity!" + "\n");
        Console.WriteLine($"{_description}" + "\n");
        Console.Write("How long, in seconds, would you like for your session?  ");
        _duration = Convert.ToInt32(Console.ReadLine());

        
    }

    public void EndMessage() 
    {
        Console.WriteLine("Well Done!");
        LoadingAnimation();
        Console.WriteLine($"You have completed {_duration} secounds of the {_activityName} Activity.");
        LoadingAnimation();  
    }

    public void LoadingAnimation(int index = 3)
    {
        while (index > 0)
        {
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");


            index--;
        }

    }
}
