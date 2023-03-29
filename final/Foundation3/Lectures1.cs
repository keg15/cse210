public class Lectures1 : Event
{
    string _speaker;
    int _capacity;
    public Lectures1(string speaker, int capacity) : base ("How to Eat Chicken","Mr. Howard will teach how to properly eat a chicken.","November 23, 2385", "50 minutes")
    {
        _speaker = speaker;
        _capacity = capacity;
        _event = "Lecture";
        _address = new Address("W Street", "Snowflake", "Arizona", "United States");
    }
}