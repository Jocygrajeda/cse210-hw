public class Cycling : Activity
{
    private double Speed { get; set; }

    //constructor for the class
    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        Speed = speed;
    }

    public override double GetSpeed()//overrides base class method, provides specefic speed for cycling
    {
        return Speed;
    }

    public override double GetPace()//"" to calculate pace based on cycling speed
    {
        return 60 / Speed;
    }

    public override string GetSummary()//"" to provide a summary (cycling)
    {
        return $"{base.GetSummary()} - Cycling ({Minutes} min): Speed {Speed} kph, Pace: {GetPace()} min per km";
    }
}
