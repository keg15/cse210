public abstract class Goal
{
    protected int _points;
    protected string _description;
    protected string _name;
    protected bool _complete = false;
    public Goal(){}

    public abstract void DisplayGoal();
    public abstract void AddPoints(ref int totalPoints);
    public void CompletedGoal()
    {
        _complete = true;
    }     
}