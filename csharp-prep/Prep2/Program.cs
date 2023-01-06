using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write ("Enter your grade ");
        string grade = Console.ReadLine();
        int Grade = int.Parse(grade);

       if (Grade >= 90)
       {
        Console.WriteLine("You got an A.");
       }
       else if(Grade >= 80)
       {
        Console.WriteLine("You got a B.");
       }
       else if (Grade >= 70)
       {
        Console.WriteLine("You got a C.");
       }
       else if (Grade >= 60)
       {
        Console.WriteLine("You got a D.");
       }
       else
       {
        Console.WriteLine("You got an F.");
       }

       string passing = Console.ReadLine();
       int Passing = int.Parse(passing);
       string TextVersion = passing.ToString();
       if (Passing >= 70)
       {
        Console.WriteLine("You passed!");
       }
       else
       {
        Console.WriteLine("You didn't pass. You can do it next time!");
       }
    }
}