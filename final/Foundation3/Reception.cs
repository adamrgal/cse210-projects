public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string desc, string date, string time, string addr, string rsvpEmail)
        : base(title, desc, date, time, addr)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        string details = GetStandardDetails() + "\n";
        details += "Type: Reception\n";
        details += "RSVP Email: " + _rsvpEmail;
        return details;
    }

    protected override string GetEventType()
    {
        return "Reception";
    }
}