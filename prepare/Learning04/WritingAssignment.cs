public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string name, string subject, string title)
        : base(name, subject)
    {
        _title = title;
    }

    public string ShowWritingDetails()
    {
        string name = GetStudentName();
        return $"{_title} by {name}";
    }

    // public override string Display()
    // {
    //     base.Display();
    //     return ShowWritingDetails();
    // }
}
