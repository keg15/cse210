using System;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        string choice = "hj";
        List<Goal> _goals = new List<Goal>();

        while (choice != "6")
        {
            Console.WriteLine($"You have {totalPoints} points.\n");
            Console.Clear();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1: Create New Goal");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Save Goals");
            Console.WriteLine("4: Load Goals");
            Console.WriteLine("5: Record Event");
            Console.WriteLine("6: Quit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string numberChoice = "0";
                while (numberChoice != "4")
                {
                    Console.Clear();
                    Console.WriteLine("What type of goal would you like to create? ");
                    Console.WriteLine("1: Simple Goal");
                    Console.WriteLine("2: Eternal Goal");
                    Console.WriteLine("3: Checklist Goal");
                    Console.WriteLine("4: Back <--");
                    numberChoice = Console.ReadLine();
                    
                    if(numberChoice == "1")
                    {
                        _goals.Add(new Simple());
                    }
                    else if(numberChoice == "2")
                    {
                        _goals.Add(new Eternal());
                    }
                    else if (numberChoice == "3")
                    {
                        _goals.Add(new Checklist1());
                    }
                }
            }
            else if (choice == "2")
            {
                //list goals
            }
            else if (choice == "3")
            {
                //save goals
            }
            else if (choice == "4")
            {
                //load goals
            }
            else if (choice == "5")
            {
                //record event
                int count = 1;
                int countChoice = 0;
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{count ++}. {goal}");
                }
                countChoice = int.Parse(Console.ReadLine());
                _goals [count -1].AddPoints(ref totalPoints);
            }
        }    
    }
}