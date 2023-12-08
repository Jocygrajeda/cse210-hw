
public class Activity
{
    private DateTime Date { get; set; }
    protected int Minutes { get; set; }

    public Activity(DateTime date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0;//class assumes no distance
    }

    public virtual double GetSpeed()
    {
        return 0;//class assumes no speed
    }

    public virtual double GetPace()
    {
        return 0;//class assumes no pace
    }

    protected virtual string GetDetails()
    {
        return $"- Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }


    //get summary of the activity
    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({Minutes} min): {GetDetails()}";
    }
    //get summary w details
    public string GetSummaryWithDetails()
    {
        return $"{GetSummary()} - Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}

