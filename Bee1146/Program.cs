using System;

namespace Bee1146
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int X = int.Parse(Console.ReadLine());

            while (X > 0)
            {
                for (int i = 1; i <= X; i++)
                {
                    if (i < X)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                X = int.Parse(Console.ReadLine());
            }
        }
    }
}