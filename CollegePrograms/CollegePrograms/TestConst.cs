using System;

class TestConst
{
    static void Main(string[] args)
    {
        const double pi = 3.14159;
        double r;

        Console.WriteLine("Enter Radius:");
        r = Convert.ToDouble(Console.ReadLine());

        double area = pi * r * r;

        Console.WriteLine("Radius = {0}, Area = {1}", r, area);

        Console.ReadLine();
    }
}