using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        int number = -1;
        int total = 0;
        int average;
        int max;
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
            else
            {
                foreach (int numberInput in numbersList)
                {
                    total = total + numberInput;
                }
                Console.WriteLine($"The sum is: {total}");

                average = total/numbersList.Count;
                Console.WriteLine($"The average is: {average}");

                max = numbersList.Max();
                Console.WriteLine($"The largest number is: {max}");
            }
        }
    }
}