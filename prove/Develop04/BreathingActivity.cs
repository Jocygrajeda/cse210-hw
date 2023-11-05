class BreathingActivity : Activity
{
    private const int BreathingInCountdown = 5;
    private const int BreathingOutCountdown = 5;

    public override void Start()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int duration = GetDuration();
        Console.WriteLine();

        Console.Write($"Get ready to\n");
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;

        for (int i = 0; i < 5; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.Write(" ");  // Clear the last spinner character
        Console.WriteLine();

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("Breathe in...");
            CountDown(BreathingInCountdown);

            Console.Write("Now, breathe out...");
            CountDown(BreathingOutCountdown);

            Console.WriteLine();
        }

        Console.WriteLine($"Well done!");

        // Spinner animation after "Well done!" message
        string[] spinnerAnimation = { "|", "/", "-", "\\" };
        for (int i = 0; i < 5; i++)
        {
            Console.Write(spinnerAnimation[i % spinnerAnimation.Length]);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.Write(" ");  // Clear the last spinner character
        Console.WriteLine();

        Console.WriteLine($"You have completed {duration} seconds of the Breathing Activity.");
        Spinner(3);
        Console.Clear();
    }
}
