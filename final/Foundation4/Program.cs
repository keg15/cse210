using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        Console.Clear();
        List<Activity> activitiesList = new List<Activity>();
        activitiesList.Add(new Running(6, "November 21", 50));
        activitiesList.Add(new Cycling(15, "June 4", 30));
        activitiesList.Add(new Swimming(10, "July 5", 15));
        foreach (Activity a in activitiesList)
        {
            a.Summary();
        }
    }
}