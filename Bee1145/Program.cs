using System;
using System.Runtime.CompilerServices;

namespace Bee1145
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');

            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            int meio = 0;
            int fim = 0;

            for (int i = 1; i <= Y; i++)
            {
                Console.WriteLine(i);

                for (int j = 1; j <= X;)
                {
                    Console.Write(j);
                }
            }
        }
    }
}