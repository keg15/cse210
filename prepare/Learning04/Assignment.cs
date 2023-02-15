public class Assignment
{
    private string _name;
    private string _subject;

    public Assignment(string name, string subject)
    {
        _name = name;
        _subject = subject;
    }

    public string GetStudentName()
    {
        return _name;
    }

    public string GetSubject()
    {
        return _subject;
    }

    public string Display()
    {
        return $"{_name} - {_subject}";
    }
}