using System;

class PosNeg
{
    static void Main(string[] args)
    {
        for (int i = -5; i <= 5; i++)
        {
            Console.WriteLine("Testing: " + i);

            if (i < 0)
                Console.WriteLine("Negative");
            else if (i > 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Zero");
        }
    }
}