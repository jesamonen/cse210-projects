using System;

// Goal completed once
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent() => _isComplete = true;

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
        => _isComplete ? $"[X] {_name}" : $"[ ] {_name}";

    public override string GetStringRepresentation()
        => $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";

    public static SimpleGoal FromString(string[] p)
    {
        SimpleGoal g = new SimpleGoal(p[1], p[2], int.Parse(p[3]));
        g._isComplete = bool.Parse(p[4]);
        return g;
    }
}