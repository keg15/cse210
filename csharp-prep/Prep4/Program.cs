using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            
            if (number != 0)
            {
                numbersList.Add(number);
            }

            int total = 0;
            foreach (int numberInput in numbersList)
            {
                total = total + numberInput;
                Console.Write($"The sum is {total}");
            }
        }
    }
}