using System;

class Prime
{
    static void Main()
    {
        int num;
        int i;
        int factor;
        bool isprime;

        for (num = 2; num < 20; num++)
        {
            isprime = true;
            factor = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if ((num % i) == 0)
                {
                    isprime = false;
                    factor = i;
                }
            }

            if (isprime)
                Console.WriteLine(num + " is prime.");
            else
                Console.WriteLine("Largest factor of " + num + " is " + factor);
        }
    }
}