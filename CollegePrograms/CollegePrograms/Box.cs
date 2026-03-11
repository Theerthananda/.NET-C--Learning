using System;

class Box
{
    static void Main(string[] args)
    {
        int i = 10;
        object obj;

        obj = i;   // Boxing
        Console.WriteLine("Boxed value: " + obj);

        obj = 20;
        int j = (int)obj;   // Unboxing

        Console.WriteLine("Unboxed value: " + j);
    }
}