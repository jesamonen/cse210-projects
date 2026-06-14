using System;

// Goal with multiple steps + bonus
public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _current = 0;
    }

    public override void RecordEvent() => _current++;

    public override bool IsComplete() => _current >= _target;

    public override string GetDetailsString()
        => $"[ ] {_name} ({_current}/{_target})";

    public override string GetStringRepresentation()
        => $"ChecklistGoal|{_name}|{_description}|{_points}|{_current}|{_target}|{_bonus}";

    public static ChecklistGoal FromString(string[] p)
    {
        ChecklistGoal g = new ChecklistGoal(
            p[1], p[2],
            int.Parse(p[3]),
            int.Parse(p[5]),
            int.Parse(p[6])
        );

        g._current = int.Parse(p[4]);
        return g;
    }
}