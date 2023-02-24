public class Breathe : Activity
{
    public Breathe(string activityName, string description, int length) : base(activityName,description,length)
    {
    }
    public void Breath()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetSeconds());
        while(startTime < endTime)
        {
            Console.WriteLine("Breathe in...");
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("Breathe out...");
            Console.Write("\b \b");
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            startTime = DateTime.Now;
        }
        Console.WriteLine("\n");
    }
}