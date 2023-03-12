public class Goals
{
    int _score = 0;
    int _points = 0;
    int _pointsWanted = 0;
    public Goals()
    {
    }
    List<string> goals = new List<string>();

    public virtual void DisplayGoal()
    {
        Console.WriteLine("The goals are: ");
        if (_points != _pointsWanted)
        {
            Console.WriteLine($"{goals} Completed: [] {_points}/{_pointsWanted}");
        }
        else
        {
            Console.WriteLine($"{goals} Completed: [X] {_pointsWanted}/{_pointsWanted}");
        }
    }

    public virtual void CreateGoal()
    {
        string numberChoice = MainMenu();
        while (numberChoice != "4")
        {
            Console.WriteLine("What is the name of your goal and a short description of it?");
            goals.Add(Console.ReadLine());
            Console.WriteLine("What is the amount of points associated with this goal?");
            _pointsWanted.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine($"You have {_score} points.");
            numberChoice = MainMenu();
            MainMenu();
        }
        static string MainMenu()
        {
            string choice;
            Console.Clear();
            Console.WriteLine("What type of goal would you like to create? ");
            Console.WriteLine("1: Simple Goal");
            Console.WriteLine("2: Eternal Goal");
            Console.WriteLine("3: Checklist Goal");
            Console.WriteLine("4: Back <--");
            choice = Console.ReadLine();
            return choice;
        }
    }
}