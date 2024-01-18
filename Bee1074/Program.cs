using System;

namespace Bee1074
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int X = 0;

            for (int i = 1; i <= N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X % 2 == 0 && X != 0)
                {
                    Console.Write("EVEN");

                    if (X > 0)
                    {
                        Console.WriteLine(" POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine(" NEGATIVE");
                    }
                }
                else if (X % 2 != 0) 
                {
                    Console.Write("ODD");

                    if (X > 0)
                    {
                        Console.WriteLine(" POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine(" NEGATIVE");
                    }
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
