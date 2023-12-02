using System.IO;

public class Activity 
{
    public int _duration;
    public string _description;
    public string _activityName;
    public int _pauseStart;
    private int _pauseEnd;
    private string _endingMessage;

    public Activity(int duration, string description, string activityName, int pauseStart, int pauseEnd, string endingMessage)
    {
        _duration = duration;
        _description = description;
        _activityName = activityName;
        _pauseStart = pauseStart;
        _pauseEnd = pauseEnd;
        _endingMessage = endingMessage;
    }
    public void DisplayStartingMessage(string activityName, string message)
{
    _description = message;
    _activityName = activityName;
    Console.Clear();
    Console.WriteLine($"Welcome to the {_activityName} Activity.\n");
    Console.WriteLine(_description);
    Console.WriteLine();

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

    public void DisplayHoldAnimation(int pauseSeconds)
    {
        string[] spinner = {"-","|", "/" };
        for (int i = 0; i < pauseSeconds; i++ ){
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(450);
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
        }
    }
    public void StartPause(int duration = 5)//10
    {
        DisplayHoldAnimation(duration);
    }
//adding messages

    private readonly Random _random = new Random();
    public void DisplayEndingMessage(string activityName)
    {
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have completed the {activityName} activity.");
        Console.WriteLine($"You engaged in this activity for {_duration} seconds.");
        Console.WriteLine(_endingMessage);
        StartPause();

        if (_random.Next(1, 5) == 1)
        {
            DisplaySurpriseMessage();
        }
    }

    private void DisplaySurpriseMessage()
    {
        Console.WriteLine("Surprise! You found a hidden message!");
        Console.WriteLine("Thanks for using this program!");
    }

    public void StartActivity(string _activityName, string _description)
    {
        Console.Clear();
        StartPause();
        DisplayStartingMessage(_activityName, _description);
    }
}