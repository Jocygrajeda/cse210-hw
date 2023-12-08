public class Reception : Event
{
    private string RsvpEmail { get; set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address eventAddress, string rsvpEmail)
        : base(title, description, date, time, eventAddress)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Reception\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}
