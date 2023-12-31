public class OutdoorGathering : Event
{
    private string WeatherStatement { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address eventAddress, string weatherStatement)
        : base(title, description, date, time, eventAddress)
    {
        WeatherStatement = weatherStatement;
    }

    public override string GenerateFullDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {EventAddress.GetFullAddress()}\nType: Outdoor Gathering\nWeather: {WeatherStatement}";
    }


    public override string GenerateShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}
