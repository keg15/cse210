using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        Reference oneVerseReference = new Reference("Proverbs", "3", "5");
        Scripture scripture1 = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Scripture scripture2 = new Scripture(oneVerseReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        string line = "";
        while(line != "quit")
        {
            Console.Clear();
            scripture1.Display();
            if (scripture1.isCompletelyHidden())
            {
                line = "quit";
                break;
            }
            Console.WriteLine("\n\nPress enter to continue or type quit.");
            line = Console.ReadLine();
            scripture1.HideWords();
        }


    }
}