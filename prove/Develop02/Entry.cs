public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;
    public string _location;
    public Entry(string date, string prompt, string entry,string mood,string location)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entry;
        _mood = mood;
        _location = location;
    }
    public void Display()
    {
        Console.WriteLine($"Date:{_date}　ーLocation :{_location}- Mood :{_mood} - Prompt:{_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();

    }
    public string stringify()
    {
        return ($"Date:{_date} - Prompt:{_promptText} \n {_entryText}");

    }
}