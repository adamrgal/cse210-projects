public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals never "finish", so we do nothing to the state here.
        // The manager handles adding the points.
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        // Format: EternalGoal:Name,Description,Points
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}