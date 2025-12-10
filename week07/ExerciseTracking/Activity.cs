using System;
using System.Globalization;
using System.Reflection.Metadata;
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public DateTime GetDate() => _date;
    public int GetMinutes() => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        CultureInfo ci = new CultureInfo("en-Us");

        return $"{_date.ToString("dd MMM yyyy", ci)} {this.GetType().Name} ({_minutes} min): "+
               $"Distance {GetDistance().ToString("0.0", ci)} kilometers, "+
               $"Speed {GetSpeed().ToString("0.0", ci)} kph, "+
               $"Pace: {GetPace().ToString("0.0", ci)} min per kilometer";
    }
}