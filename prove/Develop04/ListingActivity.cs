using System.Reflection;

public class ListingActivity : Activity
{
    private List<string> _listingPrompt = new List<string>();

    public ListingActivity(string ActivityName, string Description) : base(ActivityName, Description)
    {

    }

        public void GetListingPrompt()
    {
        int waitTime = 5;

        Console.WriteLine("Starting Listing Activity in 3 seconds...");
        LoadingAnimation();

        Console.WriteLine("List as many responses you can to the following prompt: " + "\n");
        Console.WriteLine(GetRandomListingPrompt() + "\n");
        
        for(int i = waitTime; i > 0; i--) 
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1));
                Console.Write("\r" + $"You may begin in: {i}");
                Thread.Sleep(1000);    
            }
        Console.WriteLine();


    }
    public void RecordListing()
    {
        Console.WriteLine("Please list your answers to the prompt!");

        int itemCount = 0;
        int runTime = _duration - 5;
        while (runTime > 0)
        {
            if (Console.KeyAvailable)
            {
                var input = Console.ReadLine();
                if (input != "")
                {
                    itemCount++;
                }
            }

            Thread.Sleep(1000);
            runTime--;
        }

        Console.WriteLine($"You entered {itemCount} answers!");
    }

    public string GetRandomListingPrompt()
    {
        _listingPrompt.Add("Who are people that you appreciate?");
        _listingPrompt.Add("What are personal strengths of yours?");
        _listingPrompt.Add("Who are people that you have helped this week?");
        _listingPrompt.Add("When have you felt the Holy Ghost this month?");
        _listingPrompt.Add("Who are some of your personal heroes?");


        Random random = new Random();
        int index;
        string selectedPrompt;


        index = random.Next(_listingPrompt.Count);
        selectedPrompt = _listingPrompt[index];
        _listingPrompt.RemoveAt(index);

        return selectedPrompt; 
    }
}