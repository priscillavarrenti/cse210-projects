public class SimpleGoal : Goal 
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base (name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
       if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        } 
        return 0;
    }
    public override string GetStatus()
    {
        string check = _isComplete ? "[X]" : "[ ]";
        return $"{check} {_name} ({_description})";
    }
    public override string SaveFormat()
    {
        return $"SimpleGoal, {_name}, {_description}, {_points}, {_isComplete}";
    }
}