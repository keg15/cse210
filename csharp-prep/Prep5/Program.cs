using System;

class Program
{
    static void Main(string[] args)
    {
        welcome();
        string name = inputName();
        int number = inputNumber();
        int squaredNumber = inputSquaredNumber(number);
        result(name, squaredNumber);
    }

    static void welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

static string inputName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int inputNumber()
    {
        Console.Write("Please enter your favortie number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int inputSquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void result(string name, int square)
    {
        Console.Write($"{name} the square root of your number is {square}.");
    }
}