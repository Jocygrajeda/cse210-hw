public class Running : Activity
{
    private double Distance { get; set; }

    public Running(DateTime date, int minutes, double distance)//constructor
        : base(date, minutes)
    {
        Distance = distance;
    }

    public override double GetDistance()//overrides base class method, provides specefic distance for running
    {
        return Distance;
    }

    public override double GetSpeed()//overrides base class method,calculate speed based on running distance
    {
        return Distance / Minutes * 60;
    }

    public override double GetPace()//overrides base class method, calculate pace based on running distance
    {
        return Minutes / Distance;
    }

    public override string GetSummary()//summary
    {
        return $"{base.GetSummary()} - Running ({Minutes} min): Distance {Distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
