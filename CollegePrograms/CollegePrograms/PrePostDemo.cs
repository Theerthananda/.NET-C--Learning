using System;

class PrePostDemo
{
    static void Main()
    {
        int x = 2;
        int y = 0;

        Console.WriteLine("Series generated using y = y + x++");

        for (int i = 0; i < 10; i++)
        {
            y = y + x++;
            Console.WriteLine(y);
        }
    }
}