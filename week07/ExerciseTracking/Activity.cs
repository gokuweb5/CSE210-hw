using System;
using System.Globalization;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int Minutes => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    protected virtual string GetActivityName()
    {
        return "Activity";
    }

    public virtual string GetSummary()
    {
        string dateText = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        return $"{dateText} {GetActivityName()} ({_minutes} min)- " +
               $"Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }
}