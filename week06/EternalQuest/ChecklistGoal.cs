public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _current = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _current++;
        int total = _points;

        if (_current == _target)
        {
            total += _bonus;
        }

        return total;
    }

    public override bool IsComplete() => _current >= _target;

    public override string GetStatus()
    {
        return $"[{(_current >= _target ? "X" : " ")}] Completed {_current}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_current},{_bonus}";
    }
}