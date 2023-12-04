using System;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _question = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public Reflection(int duration, string description, string activityName, int pauseStart, int pauseEnd, string endingMessage)
        : base(duration, description, activityName, pauseStart, pauseEnd, endingMessage)//initializing reflection activity
    {
        //prompts
        _prompts.Add("--Think of a time when you stood up for someone else.--");
        _prompts.Add("--Think of a time when you did something really difficult.--");
        _prompts.Add("--Think of a time when you helped someone in need.--");
        _prompts.Add("--Think of a time when you did something truly selfless.--");
    }

    //overridden method to start the Reflection activity
    public override void StartActivity()
    {
        base.StartActivity();
        PerformReflectionActivity();
        DisplayEndingMessage();
    }

    private void PerformReflectionActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...\n");
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        StartPause();
        
        //select random prompt
        int randomIndex = _random.Next(_prompts.Count);
        Console.WriteLine(_prompts[randomIndex]);
        StartPause();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

        //record start time for activity duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

         //loop through reflection questions during the activity duration
        while (DateTime.Now < endTime)
        {
            Console.Clear();

            //select random question from the list
            int randomQuestionIndex = _random.Next(_question.Count);
            Console.WriteLine("> " + _question[randomQuestionIndex]);
            _question.RemoveAt(randomQuestionIndex);

            StartPause(10);//pause before displaying the next question
            Console.WriteLine();
        }
        Console.WriteLine("\nWell Done\n");
        StartPause();
    }
}
