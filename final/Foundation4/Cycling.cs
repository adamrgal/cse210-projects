public class Cycling : Activity
{
    private double _speed; // In mph

    public Cycling(string date, int durationMinutes, double speed) 
        : base(date, durationMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Distance = (speed * minutes) / 60
        return (_speed * GetDuration()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}