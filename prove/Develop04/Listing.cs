using System;
using System.Collections.Generic;
using System.IO;//text
using System.Threading.Tasks;//countdown

public class Listing : Activity
{
    private List<string> _randomQuestion = new List<string>();
    private List<string> _userList = new List<string>();
    private string _logFilePath = "listing_log.txt";//file path for logging user responses 

    //initializing breathing activity details
    public Listing(int duration, string description, string activityName, int pauseStart, int pauseEnd, string endingMessage)
        : base(duration, description, activityName, pauseStart, pauseEnd, endingMessage)
    {

        //random questions 
        _randomQuestion.Add(" ---Who are people that you appreciate?---");
        _randomQuestion.Add(" ---What are personal strengths of yours?---");
        _randomQuestion.Add(" ---Who are people that you have helped this week?---");
        _randomQuestion.Add(" ---When have you felt the Holy Ghost this month?---");
        _randomQuestion.Add(" ---Who are some of your personal heroes?---");
    }

    public override void StartActivity()
    {
        base.StartActivity();
        GetRandomList();  //get a random question, allow user input, save log, and display ending message
        SaveLog(); //saving user input
        DisplayEndingMessage();
    }


    private void GetRandomList()
    {
        Console.Clear();
        StartPause();
        Console.WriteLine("Get ready...\n");
        StartPause();
        int index = _random.Next(0, _randomQuestion.Count);//select random question from the list
        Console.WriteLine($"List as many responses as you can to the following prompt:\n{_randomQuestion[index]}");
        
        // Countdown from 5 to 1
        for (int i = 5; i >= 1; i--)
        {
            Console.Write($"{i} ");
            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine("\nYou may begin now:");

        DateTime startTime = DateTime.Now;//record user responses for the specified duration
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            _userList.Add(Console.ReadLine());
        }

        int listLength = _userList.Count;  //display the number of items listed by the user
        Console.WriteLine($"Number of listed items: {listLength}");
        Console.WriteLine();
        Console.WriteLine("Well Done");
        StartPause();
    }

    private void SaveLog()//save user responses to a log file
    {
        using (StreamWriter sw = File.AppendText(_logFilePath))
        {
            sw.WriteLine($"Log from {DateTime.Now}");
            foreach (string item in _userList)
            {
                sw.WriteLine(item);
            }
            sw.WriteLine();
        }
    }
    
    public void Countdown(int seconds) //countdown
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}