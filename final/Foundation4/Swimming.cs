public class Swimming : Activity
{
    private int Laps { get; set; }
    private const double LapLengthMeters = 50.0;

    public Swimming(DateTime date, int minutes, int laps)//constructor
        : base(date, minutes)
    {
        Laps = laps;
    }

    public override double GetDistance()//overrides base clase, calculate distance based on swimming laps
    {
        return Laps * LapLengthMeters / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / Minutes * 60;//calculate speed based on swimming distance
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();//calculate pace based on swimming distance
    }

    public override string GetSummary()//summary
    {
        return $"{base.GetSummary()} - Swimming ({Minutes} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
