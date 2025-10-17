using System.Runtime.ExceptionServices;
using System.IO;
public class Journal
{
    public List<Entry> _JournalList = new List<Entry>();


    public Journal()
    {

    }
    public void LoadFromFile(string filename)
{
    _JournalList.Clear(); // Clear existing entries
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split("~|~");
        if (parts.Length == 5)
        {
            Entry loadedEntry = new Entry(parts[0], parts[3], parts[4], parts[2], parts[1]);
            _JournalList.Add(loadedEntry);
        }
    }
    Console.WriteLine($"Journal loaded from {filename}");
}
    
    public void AddEntry(Entry newEntry)
    {
        _JournalList.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry one in _JournalList)
        {
            one.Display();
        }

    }
  public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry one in _JournalList)
            {
                outputFile.WriteLine(one.stringify());
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }
}