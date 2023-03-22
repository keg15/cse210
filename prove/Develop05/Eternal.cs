public class Eternal : Goal
{
    public Eternal()
    {
        Console.WriteLine("What is the name of your goal?");
        _name = (Console.ReadLine());
        Console.WriteLine("What is a short description of your goal?");
        _description = (Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal?");
        _points = (int.Parse(Console.ReadLine()));
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{_name}: {_description} {_points} points");
    }

    public override void AddPoints(ref int totalPoints)
    {
        _points += totalPoints;
    }
}