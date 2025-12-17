// File: Event.cs
public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        string details = "Title: " + _title + "\n";
        details += "Description: " + _description + "\n";
        details += "Date: " + _date + "\n";
        details += "Time: " + _time + "\n";
        details += "Address: " + _address;
        return details;
    }

    public string GetShortDescription()
    {
        return GetEventType() + ": " + _title + " on " + _date;
    }

    public abstract string GetFullDetails();
    protected abstract string GetEventType();
}