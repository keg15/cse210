using System;

class Program
{
    static void Main(string[] args)
    {
        FractionLearning3 fraction1 = new FractionLearning3();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDeciamlValue());

        FractionLearning3 fraction2 = new FractionLearning3(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDeciamlValue());

        FractionLearning3 fraction3 = new FractionLearning3(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDeciamlValue());

        FractionLearning3 fraction4 = new FractionLearning3(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDeciamlValue());
    }
}