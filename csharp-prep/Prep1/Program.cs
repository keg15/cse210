using System;

class Program
{
    static void Main(string[] args)
    {
        string FirstName = Console.ReadLine();
        string LastName = Console.ReadLine();

        Console.Write("What is your first name?");
        Console.Write("What is your last name?");

        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}." );
    }
}