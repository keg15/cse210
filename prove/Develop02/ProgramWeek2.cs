using System;

class ProgramWeek2
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();    //creates a new instance of Journal (the class)
        string numberChoice = MainMenu();
        while (numberChoice != "5")
        {
            if (numberChoice == "1")
            {
                Entry newEntry = new Entry();
                newEntry.UserWrite();
                journal._entry.Add(newEntry);
            }
            else if (numberChoice == "2")
            {
                journal.Display();
            }
            else if (numberChoice == "3")
            {
                journal.ReadFile();
                //load-pulls up the saved stuff
            }
            else if (numberChoice == "4")
            {
                //save
                journal.SaveFile();
                Console.WriteLine("Your file has been saved as myJournal.txt");
            }
            else
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
            numberChoice = MainMenu();
        }
    }    
    static string MainMenu()
    {
        string choice;
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Display");
        Console.WriteLine("3: Load");
        Console.WriteLine("4: Save");
        Console.WriteLine("5: Quit");
        choice = Console.ReadLine();
        return choice;  
    }
}