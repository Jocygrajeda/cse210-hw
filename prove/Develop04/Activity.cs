using System;

public class Activity
{
    //protected fields for storing activity details
    protected int _duration;
    protected string _description;
    protected string _activityName;
    protected int _pauseStart;
    private int _pauseEnd;
    private string _endingMessage;
    protected Random _random = new Random();

    //constructior to initialize activity details
    public Activity(int duration, string description, string activityName, int pauseStart, int pauseEnd, string endingMessage)
    {
        _duration = duration;
        _description = description;
        _activityName = activityName;
        _pauseStart = pauseStart;
        _pauseEnd = pauseEnd;
        _endingMessage = endingMessage;
    }

    //displaying starting message and get user input for duration
    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.\n");
        Console.WriteLine(_description);
        Console.WriteLine();
        GetUserDurationInput();
    }

    private void GetUserDurationInput()
    {
        int userInput;
        bool validInput = false;

        do
        {
            Console.Write("How long, in seconds, would you like your session? ");
            string input = Console.ReadLine();

            validInput = int.TryParse(input, out userInput);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        } while (!validInput);

        _duration = userInput;
    }

    //display spinner
    protected void DisplayHoldAnimation(int pauseSeconds)
    {
        string[] spinner = { "-", "|", "/"  };
        for (int i = 0; i < pauseSeconds; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            System.Threading.Thread.Sleep(550);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }

    protected void StartPause(int duration = 5)//pause duration of 5 seconds
    {
        DisplayHoldAnimation(duration);
    }

    public virtual void DisplayEndingMessage()//virtual method to display a message at the end of the activity
    {
        Console.WriteLine($"Congratulations! You have completed the {_activityName} activity.");
        Console.WriteLine($"You engaged in this activity for {_duration} seconds.");
        Console.WriteLine(_endingMessage);
        StartPause();

        if (_random.Next(1, 5) == 1)
        {
            DisplaySurpriseMessage();
        }
    }

    private void DisplaySurpriseMessage()//display hidden message
    {
        Console.WriteLine("Surprise! You found a hidden message!");
        Console.WriteLine("Thanks for using this program!");
    }

    public virtual void StartActivity() //method to start activity
    {
        Console.Clear();
        StartPause();
        DisplayStartingMessage();
    }
}

//showing creativity by adding a txt where the input from the user in listing is store and displaying a hidden message.