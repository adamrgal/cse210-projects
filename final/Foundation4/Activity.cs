// File: Activity.cs
using System;

public abstract class Activity
{
    private string _date;
    private int _durationMinutes;

    public Activity(string date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public int GetDuration()
    {
        return _durationMinutes;
    }

    // Abstract methods to be overridden by specific activities
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        // Formatting: 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{_date} {this.GetType().Name} ({_durationMinutes} min): " +
               $"Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}