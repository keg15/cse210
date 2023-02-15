public class MathAssignment : Assignment
{
    private string _page;
    private string _startNumber;
    private string _endNumber;

    public MathAssignment(string name, string subject, string page, string startNumber, string endNumber)
        : base(name, subject)
    {
        _page = page;
        _startNumber = startNumber;
        _endNumber = endNumber;
    }

    public string ShowMathAssignment()
    {
        return $"Page: {_page} Problems: {_startNumber}-{_endNumber}";
    }
}