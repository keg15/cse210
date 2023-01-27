public class Entry
{
    public Entry()
    {
    }

    public string _entry;
    public string _prompts;
    public string date;

    //displays the date, prompt, then entry
    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {_prompts}");
        Console.WriteLine(_entry);
    }

    public void UserWrite()
    {
       PromptGenerator prompt = new PromptGenerator();
        _prompts = prompt.Generator();
        Console.WriteLine(_prompts);
        _entry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        date = theCurrentTime.ToShortDateString();
    }

    public void CreateEntryFromArray(string entry, string dt)
    {
        _entry = entry;
        date = dt;

    }
}