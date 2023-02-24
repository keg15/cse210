public class List : Activity
{
    public List(string activityName, string description, int length) : base(activityName,description,length)
    {   
    }
    public void Listing()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetSeconds());
        List<string> count = new List<string>();
        while(startTime < endTime)
        {
            Console.WriteLine(ListGenerator());
            count.Add(Console.ReadLine());

            startTime = DateTime.Now;
        }
        Console.WriteLine($"You entered: {count.Count} answers.");
    }

    public string ListGenerator()
    {
        List<string> lists = new List<string>();
        lists.Add("What are your personal talents?");
        lists.Add("When have you felt loved this week?");
        lists.Add("What have you done to make others feel loved?");
        lists.Add("What spiritual gifts do you have?");
        lists.Add("Who is your personal hero?");

        Random num3 = new Random();
        int number3 = num3.Next(0, 5);
        return lists[number3];
    }
}