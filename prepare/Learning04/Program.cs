using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Sara Kelp", "Math");
        Console.WriteLine(assignment.Display());

        MathAssignment mathAssignment = new MathAssignment("Tim Page", "Decimals", "79", "4", "27");
        Console.WriteLine(mathAssignment.Display());
        Console.WriteLine(mathAssignment.ShowMathAssignment());
        

        WritingAssignment writingAssignment = new WritingAssignment("Ben Smith", "English Literature", "The Cuban War");
        Console.WriteLine(writingAssignment.Display());
        Console.WriteLine(writingAssignment.ShowWritingDetails());
    }
}