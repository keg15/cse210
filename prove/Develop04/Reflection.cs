public class Reflection : Activity
{
    public Reflection(string activityName, string description, int length) : base(activityName,description,length)
    {
    }

    public void Reflecting()
    {
        Console.Clear();
        Pause();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetSeconds());
        Console.WriteLine(ReflectionGenerator());
        Console.ReadLine();
        while(startTime < endTime)
        {
            Console.WriteLine(ReflectionFollowUp());
            Console.ReadLine();
            startTime = DateTime.Now;
        }
    }
    
    public string ReflectionGenerator()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you served someone in need.");
        prompts.Add("Think of a time when you stood up for someone.");
        prompts.Add("Think of a time when you stood your ground.");
        prompts.Add("Think of a time when you were selfless.");
        prompts.Add("Think of a time when you didn't let others intimidate you.");
        
        Random num = new Random();
        int number = num.Next(0, 5);
        return prompts[number];
    }

    public string ReflectionFollowUp()
    {
        List<string> followUps = new List<string>();
        followUps.Add("How did it start?");
        followUps.Add("What motivated you to do this?");
        followUps.Add("What was your favorite thing about this experience?");
        followUps.Add("What did you learn from this experience?");
        followUps.Add("Would you ever do this again?");
        followUps.Add("How did others react?");
        followUps.Add("How will this change how you act in the future?");
        followUps.Add("How was this time different from other times you tried this?");
        followUps.Add("What can you teach others about this experience?");

        Random nums = new Random();
        int numbers = nums.Next(0, 9);
        return followUps[numbers];
    }
}