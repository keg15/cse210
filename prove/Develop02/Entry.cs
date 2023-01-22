public class Entry
{
    public string _userInput;
    public List<Entry> _prompts = new List<Entry>();
    DateTime theCurrentTime = DateTime.Now;
    string date = DateTime.Now.ToShortDateString();

    //displays the date, prompt, then entry
    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {_prompts}");
        
        foreach (Entry entry in _prompts)
        {
            entry.Display();
        }
    }
}