using System;

class SwitchDemo
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 8; i++)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine("i  is zero");
                    break;

                case 1:
                    Console.WriteLine("i  is one");
                    break;

                case 2:
                    Console.WriteLine("i  is two");
                    break;

                case 3:
                    Console.WriteLine("i  is three");
                    break;

                case 4:
                    Console.WriteLine("i  is four");
                    break;

                case 5:
                    Console.WriteLine("i  is five");
                    break;

                default:
                    Console.WriteLine("i  is greater than five");
                    break;
            }
        }
    }
}