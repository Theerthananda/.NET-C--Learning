using System;

class MultiplyDivide
{
    static void Main(string[] args)
    {
        int n;

        n = 10;
        Console.WriteLine("Value of n: " + n);

        n = n << 1;
        Console.WriteLine("Value of n after n=n*2: " + n);

        n = n << 2;
        Console.WriteLine("Value of n after n=n*4: " + n);

        n = n >> 1;
        Console.WriteLine("Value of n after n=n/2: " + n);

        n = n >> 2;
        Console.WriteLine("Value of n after n=n/4: " + n);

        n = 10;
        Console.WriteLine("Value of n: " + n);

        n = n << 30;
        Console.WriteLine("Value after left shifting 30 places: " + n);
    }
}