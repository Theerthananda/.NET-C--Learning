using System;

class ImplicitDemo
{
    static void Main(string[] args)
    {
        var s1 = 4.0;
        var s2 = 5.0;

        var hypot = Math.Sqrt((s1 * s1) + (s2 * s2));

        Console.WriteLine("Hypotenuse of triangle with sides {0} and {1} is {2:F3}", s1, s2, hypot);
    }
}