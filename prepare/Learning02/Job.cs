public class Job(string comp, string title, int start, int end)
{
    string _company=comp;
    string _jobTitle= title;
    int _startYear= start;
    int _endYear= end;

    public void Display()
    {
        Console.WriteLine($" {_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}