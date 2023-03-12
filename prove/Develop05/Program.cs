using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");

        string numberChoice = MainMenu();
        while (numberChoice != "6")
        {
            if (numberChoice == "1")
            {   
                //create new goals
                Simple simple = new Simple();
                simple.CreateGoal();
            }
            else if (numberChoice == "2")
            {
                //list goals
                Goals goal = new Goals();
                goal.DisplayGoal();
            }
            else if (numberChoice == "3")
            {
                //save goals
            }
            else if (numberChoice == "4")
            {
                //load goals
            }
            else if (numberChoice == "5")
            {
                //record event
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
            numberChoice = MainMenu();
        }
        
        static string MainMenu()
        {
            string choice;
            Console.Clear();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1: Create New Goal");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Save Goals");
            Console.WriteLine("4: Load Goals");
            Console.WriteLine("5: Record Event");
            Console.WriteLine("6: Quit");
            choice = Console.ReadLine();
            return choice;
        }
    }
}