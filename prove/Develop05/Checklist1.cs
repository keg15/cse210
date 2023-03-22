public class Checklist1 : Goal
{
    protected int _pointsWanted;
    protected int _bonusPoints;
    protected int _amountOfTimes;
    public Checklist1()
    {
        Console.WriteLine("What is the name of your goal?");
        _name = (Console.ReadLine());
        Console.WriteLine("What is a short description of your goal?");
        _description = (Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal?");
        _points = (int.Parse(Console.ReadLine()));
        Console.WriteLine("What is the amount of bonus points associated with this goal?");
        _bonusPoints = (int.Parse(Console.ReadLine()));
        Console.WriteLine("How many times would you like to do this goal?");
        _amountOfTimes = (int.Parse(Console.ReadLine()));
    }
    public override void DisplayGoal()
    {
        if (_points != _pointsWanted)
        {
            Console.WriteLine($"[] {_name}: {_description} {_points}/{_pointsWanted} points");
        }
        else
        {
            Console.WriteLine($"[X] {_name}: {_description} {_pointsWanted}/{_pointsWanted} points");
        }
    }

    public override void AddPoints(ref int totalPoints)
    {
        if (_amountOfTimes == _amountOfTimes)
        {
            _points += _points;
            _points += _bonusPoints;
        }
        else
        {
            _points += totalPoints;
        }
    }
}