public class Event
{
    protected string Title { get; private set; }
    protected string Description { get; private set; }
    protected DateTime Date { get; private set; }
    protected TimeSpan Time { get; private set; }
    protected Address EventAddress { get; private set; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address eventAddress)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = eventAddress;
    }

    public string GenerateStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {EventAddress.GetFullAddress()}";
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Type: Generic Event\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}
