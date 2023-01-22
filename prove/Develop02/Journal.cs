public class Journal
{
    
    public class promptGenerator
    {
        Random _prompts = new Random();
        public string Generator()
        {
            List<string> prompts = new List<string>();
            prompts.Add("Who did I serve today?");
            prompts.Add("What beautiful thing did I see today?");
            prompts.Add("What was the most fun thing I did today?");
            prompts.Add("Did I see any animals today?");
            prompts.Add("Who was the most interesting person I saw today?");
            int number = _prompts.Next(0, 5);
            return prompts[number];
        }
    }
    public void Display()
    {
        //display prompts based off of what number is
    }
}