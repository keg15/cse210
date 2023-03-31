public abstract class Activity
{
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    protected string _date;
    protected int _length;
    protected string _activity;

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public virtual void Summary()
    {
        //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
        Console.WriteLine($"{_date} {_activity} ({_length} min)- Distance {Distance()} km, {Speed()} kph, {Pace()} min per km");
    }
}