
//showing creativity by adding a txt where the input from the user in listing is store and displaying a hidden message.

using System;

//base class for various activities
public class Activity
{
    //fields for storing activity details
    protected int _duration;
    protected string _description;
    protected string _activityName;
    protected int _pauseStart;
    private int _pauseEnd;
    private string _endingMessage;
    protected Random _random = new Random();

    //array of random messages for display
    private string[] _randomMessages = {
        "Did you know that laughter can reduce stress and increase feelings of happiness?",
        "Taking a short break to stretch can improve circulation and reduce muscle tension.",
        "Deep breathing can help calm the nervous system and promote relaxation.",
        "Studies show that spending time in nature can improve mood and reduce stress levels.",
        "Listening to your favorite music can have a positive impact on your mood and stress levels.",
        "Eating a small piece of dark chocolate can release endorphins, the 'feel-good' hormones.",
        "Expressing gratitude for three things each day can lead to increased happiness.",
        "Taking short, frequent breaks during work can enhance productivity and focus.",
        "Connecting with loved ones, even through a quick call or message, can boost your mood.",
        "Did you know that smiling, even if forced, can trick your brain into feeling happier?",
    };

    //constructor to initialize activity details
    public Activity(int duration, string description, string activityName, int pauseStart, int pauseEnd, string endingMessage)
    {
        _duration = duration;
        _description = description;
        _activityName = activityName;
        _pauseStart = pauseStart;
        _pauseEnd = pauseEnd;
        _endingMessage = endingMessage;
    }

    //display starting message and get user input for duration
    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.\n");
        Console.WriteLine(_description);
        Console.WriteLine();
        GetUserDurationInput();
    }

    //get user input for activity duration
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

    //display spinner animation during pauses
    protected void DisplayHoldAnimation(int pauseSeconds)
    {
        string[] spinner = { "-", "|", "/" };
        for (int i = 0; i < pauseSeconds; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            System.Threading.Thread.Sleep(550);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }

    //start pause with spinner animation (default duration is 5 seconds)
    protected void StartPause(int duration = 5)
    {
        DisplayHoldAnimation(duration);
    }

    //virtual method to display a message at the end of the activity
    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You have completed the {_activityName} activity.");
        Console.WriteLine($"You engaged in this activity for {_duration} seconds.");
        Console.WriteLine(_endingMessage);
        StartPause();

        //display a hidden message if a random condition is met
        if (_random.Next(1, 5) == 1)
        {
            DisplaySurpriseMessage();
        }

        //display a random message
        Console.WriteLine(GetRandomMessage());
    }

    //display a surprise message
    private void DisplaySurpriseMessage()
    {
        Console.WriteLine("Surprise! You found a hidden message!");
        Console.WriteLine("Thanks for using this program!");
    }

    //get a random message from the array
    private string GetRandomMessage()
    {
        int index = _random.Next(_randomMessages.Length);
        return _randomMessages[index];
    }

    //virtual method to start the activity
    public virtual void StartActivity()
    {
        Console.Clear();
        StartPause();
        DisplayStartingMessage();
    }
}

