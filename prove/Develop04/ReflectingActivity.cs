using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

public class ReflectingActivity : Activity
{
    private List<string> _relfectingPrompt = new List<string>();
    private List<string> _question = new List<string>();

    public ReflectingActivity(string ActivityName, string Description) : base(ActivityName, Description)
    {
        
    }

    public void GetReflectionPrompt()
    {

        Console.WriteLine("Starting Reflection Activity in 3 seconds...");
        LoadingAnimation();

        Console.WriteLine("Consider the Following prompt:" + "\n");
        Console.WriteLine(GetRandomPrompt() + "\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
    }


    public void GetReflectionQuestion()
    {
        int waitTime = 5;
        int totalTimeQuestion = (_duration - waitTime) / 2;
        

        Console.WriteLine("Now ponder each of the following questions related to this experiance.");

        for(int i = waitTime; i > 0; i--) 
            {
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1));
                Console.Write("\r" + $"You may begin in: {i}");
                Thread.Sleep(1000);    
            }
        Console.WriteLine();
        Console.Write(GetRandomQuestion());
        LoadingAnimation(totalTimeQuestion);
        Console.WriteLine();
        Console.Write(GetRandomQuestion());
        LoadingAnimation(totalTimeQuestion);
        Console.WriteLine();

    }

    public string GetRandomQuestion()
    {
        _question.Add("Why was this experience meaningful to you?");
        _question.Add("Have you ever done anything like this before?");
        _question.Add("How did you get started?");
        _question.Add("How did you feel when it was complete?");
        _question.Add("What made this time different than other times when you were not as successful?");
        _question.Add("What is your favorite thing about this experience?");
        _question.Add("What could you learn from this experience that applies to other situations?");
        _question.Add("What did you learn about yourself through this experience?");
        _question.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();
        int questionIndex;
        string selectedQuestion;


        questionIndex = random.Next(_question.Count);
        selectedQuestion = _question[questionIndex];
        _question.RemoveAt(questionIndex);

        return selectedQuestion;
    }

    public string GetRandomPrompt()
    {
        _relfectingPrompt.Add("Think of a time when you stood up for someone else.");
        _relfectingPrompt.Add("Think of a time when you did something really difficult.");
        _relfectingPrompt.Add("Think of a time when you helped someone in need.");
        _relfectingPrompt.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        int index;
        string selectedPrompt;


        index = random.Next(_relfectingPrompt.Count);
        selectedPrompt = _relfectingPrompt[index];
        _relfectingPrompt.RemoveAt(index);

        return $"--- {selectedPrompt} ---";
    }
}