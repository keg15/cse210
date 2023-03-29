public class Outdoor : Event
{
    string _weather;
    public Outdoor(string weather) : base ("Woodworking","Learn how to carve your own design into wood!","July 12, 2052", "60 minutes")
    {
        _weather = weather;
        _event = "Outdoor Event";
        _address = new Address("Alligator Street", "Orlando", "Florida", "United States");
    }
}