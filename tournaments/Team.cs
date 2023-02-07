public class Team
{
    private string _name;
    private List<Player> _roster = new List<Player>();  //second part makes it so the list is blank
    private int _wins = 0;
    private int _losses = 0;

    public Team(string name)
    {
        _name = name;
    }

    public void AddPlayer( Player p)
    {
        //adds to the (private) list of players
        _roster.Add(p);
    }
    public void DisplayRoster()
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine($"Wins: {_wins} Losses: {_losses}");
        Console.WriteLine("------------------");
        foreach (Player p in _roster)
        {
            p.Display();
        }
    }

    public void AddWin()
    {
        _wins += 1;
    }

    public void AddLosses()
    {
        _losses += 1;
    }

    public string GetTeamName()
    {
        return _name;
    }
}
