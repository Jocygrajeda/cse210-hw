using System;
using System.Globalization;

public class Listing : Activity
{
    private List<string> _randomQuestion = new List<string>();
    private List<string> _userList = new List<string>();

    public Listing(int duration, string description, string activityName, int pauseStart, int pauseEnd, string endingMessage) : base(duration, description, activityName, pauseStart, pauseEnd, endingMessage)    
    {
        _randomQuestion.Add("Who are people that you appreciate?");
        _randomQuestion.Add("What are personal strengths of yours?");
        _randomQuestion.Add("Who are people that you have helped this week?");
        _randomQuestion.Add("When have you felt the Holy Ghost this month?");
        _randomQuestion.Add("Who are some of your personal heroes?");
    }
    public void GetRandomList()
    {
        StartActivity(_activityName, _description);
        Console.Clear();
        StartPause(); 
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(1,_randomQuestion.Count);
        Console.WriteLine(_randomQuestion[index]); 
        StartPause();
        Console.WriteLine("Begin in:");
        Countdown(_pauseStart);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            _userList.Add(Console.ReadLine());

        }
        int listLength = _userList.Count;
        Console.WriteLine($"Number of listed items: {listLength}");
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        StartPause();
        DisplayEndingMessage(_activityName);
    }
    public void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}