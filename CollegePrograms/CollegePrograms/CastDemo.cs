using System;

class CastDemo
{
    static void Main()
    {
        double x, y;
        byte b;
        int i;
        char ch;
        uint u;
        short s;
        long l;

        x = 10.0;
        y = 3.0;

        i = (int)(x / y);
        Console.WriteLine("Integer outcome of x/y: " + i);

        i = 255;
        b = (byte)i;
        Console.WriteLine("b after assigning 255: " + b);

        u = 32000;
        s = (short)u;
        Console.WriteLine("s after assigning 32000: " + s);

        u = 64000;
        s = (short)u;
        Console.WriteLine("s after assigning 64000: " + s + " -- data lost");

        l = 64000;
        u = (uint)l;
        Console.WriteLine("u after assigning 64000: " + u);

        l = -12;
        u = (uint)l;
        Console.WriteLine("u after assigning -12: " + u + " -- data lost");

        b = 88;
        ch = (char)b;
        Console.WriteLine("ch after assigning 88: " + ch);

        Console.ReadLine();
    }
}