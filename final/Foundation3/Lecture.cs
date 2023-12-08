public class Lecture : Event
{
    private string Speaker { get; set; }
    private int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address eventAddress, string speaker, int capacity)
        : base(title, description, date, time, eventAddress)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity} attendees";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Lecture\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}