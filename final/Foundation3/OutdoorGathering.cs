// File: OutdoorGathering.cs
public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string desc, string date, string time, string addr, string weather)
        : base(title, desc, date, time, addr)
    {
        _weatherForecast = weather;
    }

    public override string GetFullDetails()
    {
        string details = GetStandardDetails() + "\n";
        details += "Type: Outdoor Gathering\n";
        details += "Weather: " + _weatherForecast;
        return details;
    }

    protected override string GetEventType()
    {
        return "Outdoor Gathering";
    }
}