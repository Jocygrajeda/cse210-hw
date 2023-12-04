public class Breathing : Activity
{
    private int _breathIn;
    private int _breatheOut;

    //initializing breathing activity details
    public Breathing(int duration, string description, string activityName, int pauseStart, int pauseEnd, string endingMessage, int breathIn, int breathOut)
        : base(duration, description, activityName, pauseStart, pauseEnd, endingMessage)
    {
        _breatheOut = breathOut;
        _breathIn = breathIn;
    }

    public override void StartActivity()//override method to start the breathing activity
    {
        base.StartActivity();//display starting message 
        PerformBreathingActivity();
        DisplayEndingMessage();
    }

    private void PerformBreathingActivity()
    {
        int breathCount = _duration / (_breathIn + _breatheOut);//calculate the number of breathe cycles based on activity duration
        Console.Clear();
        Console.WriteLine("Get ready...\n");

        StartPause();
        for (int i = 0; i < breathCount; i++)// loop through each breathe cycle
        {
            Console.Write("Breathe in... ");
            Countdown(_breathIn);

            Console.Write("Now breathe out... ");
            Countdown(_breatheOut);
            Console.WriteLine("");
        }
    }

    private void Countdown(int seconds)//display the countdown
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"{i}  ");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        Console.WriteLine();
    }
}



