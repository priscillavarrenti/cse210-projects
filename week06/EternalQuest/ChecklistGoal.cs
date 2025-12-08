public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int count = 0)
        : base(name, description, points)
    {
       _target = target;
       _bonus = bonus;
       _count = count; 
    }
    public override int RecordEvent()
    {
        _count++;
        if (_count == _target)
            return _points + _bonus;
        return _points;
    }
    public override string GetStatus()
    {
        string check = (_count >= _target) ? "[X]" : "[ ]";
        return $"{check} {_name}({_description}) -- Currently completed {_count}/{_target}";
    }
    public override string SaveFormat()
    {
        return $"ChecklistGoal, {_name}, {_description}, {_points}, {_target}, {_bonus}, {_count}";
    }
}