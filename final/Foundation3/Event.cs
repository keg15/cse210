public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _event;
    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }
    public void Standard()
    {
        //Standard details - Lists the title, description, date, time, and address.
        Console.WriteLine($"{_title} {_description} {_date} {_time} {_address.CompleteAddress()}");
    }

    public void Full()
    {
        //Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures,
        //this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings,
        //this includes a statement of the weather.
        Console.WriteLine($"{_title} {_description} {_date} {_time} {_address.CompleteAddress()}");
    }

    public void ShortDesc()
    {
        //Short description - Lists the type of event, title, and the date.
        Console.WriteLine($"{_event} {_title} {_date}");
    }
}