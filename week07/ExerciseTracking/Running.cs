using System;
using System.Reflection.Metadata.Ecma335;
public class Running : Activity
{
    private double _distanceKm;
    public Running(DateTime date, int minutes, double distanceKm) : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }
    public override double GetDistance()
    {
        return _distanceKm;
    }
    public override double GetSpeed()
    {
        if (GetMinutes() == 0) return 0;
        return(_distanceKm / GetMinutes()) * 60;
    }
    public override double GetPace()
    {
        if (_distanceKm == 0) return 0;
        return GetMinutes() / _distanceKm;
    }
}