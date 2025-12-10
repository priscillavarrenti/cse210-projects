using System;
public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }
    public override double GetPace()
    {
        if (GetDistance() == 0)return 0;
        return GetMinutes() / GetDistance();
    }
}