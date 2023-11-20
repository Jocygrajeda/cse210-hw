
/*public class BreathingActivity : Activity
{
    public BreathingActivity(string ActivityName, string Description) : base(ActivityName, Description)
    {

    }

    public void InAndOutLoop()
    {
        int breaths = 3;
        int breathTime = _duration / (2 * breaths);

        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingAnimation();

        for (int i = 1; i <= breaths; i++)
        {
            Console.WriteLine();
            //Console.WriteLine($"Breath {i}: Breathe in for {breathTime} seconds.");
            for (int j = breathTime; j > 0; j--)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1));
                Console.Write("\r" + $"Breath In...{j}");
                Thread.Sleep(1000);
            }

            Console.WriteLine();
            //Console.WriteLine($"Breath {i}: Breathe out for {breathTime} seconds.");
            for (int j = breathTime; j > 0; j--)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1));
                Console.Write("\r" + $"Breath Out...{j}");
                Thread.Sleep(1000);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Well Done!");
    }
}
*/

public class BreathingActivity : Activity
{
    public BreathingActivity(string ActivityName, string Description) : base(ActivityName, Description)
    {

    }

    public void InAndOutLoop()
    {
        int breaths = 3;

        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingAnimation();

        for (int i = 1; i <= breaths; i++)
        {
            Console.WriteLine();
            for (int j = 5; j > 0; j--)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1));
                Console.Write("\r" + $"Breath In...{j}");
                Thread.Sleep(1000);
            }

            Console.WriteLine();
            for (int j = 5; j > 0; j--)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1));
                Console.Write("\r" + $"Breath Out...{j}");
                Console.Write(" ");
                Thread.Sleep(1000);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Well Done!");
    }
}


/*public class BreathingActivity : Activity
{
    public BreathingActivity(string ActivityName, string Description) : base(ActivityName, Description)
    {

    }

    public void InAndOutLoop(int breathDuration)
    {
        int breaths = 3;

        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingAnimation();

        int totalSessionTime = breaths * (2 * breathDuration);

        for (int i = 1; i <= breaths; i++)
        {
            Console.WriteLine();
            for (int j = breathDuration; j > 0; j--)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1));
                Console.Write("\r" + $"Breath In...{j}");
                Thread.Sleep(1000 * breathDuration / totalSessionTime);
            }

            Console.WriteLine();
            for (int j = breathDuration; j > 0; j--)
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1));
                Console.Write("\r" + $"Breath Out...{j}");
                Console.Write(" ");
                Thread.Sleep(1000 * breathDuration / totalSessionTime);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Well Done!");
    }
}
*/
