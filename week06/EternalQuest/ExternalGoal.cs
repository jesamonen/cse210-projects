using System;

// Never completes
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent() { }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
        => $"[∞] {_name}";

    public override string GetStringRepresentation()
        => $"EternalGoal|{_name}|{_description}|{_points}";

    public static EternalGoal FromString(string[] p)
        => new EternalGoal(p[1], p[2], int.Parse(p[3]));
}