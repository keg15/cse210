 public class PromptGenerator
{
    public PromptGenerator()
    {
    }
    string prompts;
    public string Generator()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who did I serve today?");
        prompts.Add("What beautiful thing did I see today?");
        prompts.Add("What was the most fun thing I did today?");
        prompts.Add("Did I see any animals today?");
        prompts.Add("Who was the most interesting person I saw today?");
        
        Random num = new Random();
        int number = num.Next(0, 5);
        return prompts[number];
    }

    public void CreateEntryFromArray(string prmpts)
    {
        prompts = prmpts;
    }
}