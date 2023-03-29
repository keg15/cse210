public class Receptions : Event
{
    public Receptions() : base ("Bob and Mary's Reception","Come support Bob and Mary's reception with us!","March 5, 2013", "45 minutes")
    {
        _event = "Reception";
        _address = new Address("Bird Street", "Chicago", "Illinois", "United States");
    }
    bool _register;
    public void Register()
    {
        if (_register == true)
        {
            Console.WriteLine("You are registered for the event. Welcome!");
        }
        else
        {
            Console.WriteLine("I'm sorry this event requires you to register beforehand.");
        }
    }
}