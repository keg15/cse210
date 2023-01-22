public class Entry
{
    public string _userInput;
    public List<Entry> _prompts = new List<Entry>();
    DateTime theCurrentTime = DateTime.Now;
    string date = DateTime.Now.ToShortDateString();

    public void Display()
    {
        Console.WriteLine($"{date} {_prompts}");
        
        foreach (Entry entry in _prompts)
        {
            entry.Display();
        }
    }
}