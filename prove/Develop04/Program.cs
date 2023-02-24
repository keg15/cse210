using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        string numberChoice = MainMenu();
        while (numberChoice != "4")
        {
            if (numberChoice == "1")
            {   
                Breathe breathe = new Breathe("Breathing Activity", "This activity will walk you through deep breathing to help relaxation", 0);
                breathe.startMessage();
                breathe.Breath();
                breathe.endMessage();
            }
            else if (numberChoice == "2")
            {
                //reflection activity
                Reflection reflection = new Reflection("Reflection Activity", "This activity will help you reflect on times of great strength in your life and help you recognize the power you have of your life.", 0);
                reflection.startMessage();
                reflection.Reflecting();
                reflection.endMessage();
            }
            else if (numberChoice == "3")
            {
                //listing activity
                List list = new List("Listing Activity", "This activity will let you list as many good things, in a ceratin area, in your life as you can.", 0);
                list.startMessage();
                list.Listing();
                list.endMessage();
            }
            else
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
            numberChoice = MainMenu();
        }
        
        static string MainMenu()
        {
            string choice;
            Console.Clear();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Reflection Activity");
            Console.WriteLine("3: Listing Activity");
            Console.WriteLine("4: Quit");
            choice = Console.ReadLine();
            return choice;
        }
    }
}