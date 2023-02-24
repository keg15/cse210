public class Activity
{
 
   private string _activityName = "";
   string _description;
   int _length;

    public Activity(string activityName, string description, int length)
    {
        _activityName = activityName;
        _description = description;
        _length = length;
    }

    public void Pause()
    {
        for(int  i=0; i<3; i++)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Console.WriteLine("\n");
    }

   public void startMessage()
   {
       Console.Clear();
       Console.WriteLine($"{_activityName}");
       Console.WriteLine($"{_description}");
       Console.WriteLine("How long would you like the activity to last (in seconds)?");
       _length = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine($"{_length} seconds");
   }
    
   public void endMessage()
   {
    Console.WriteLine("The activity has ended. Good job!");
    Pause();
   }

   public int GetSeconds()
   {
        return _length;
   }
}