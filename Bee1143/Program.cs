using System;

namespace Bee1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int meio = 1;
            int fim = 1;

            for (int i = 1; i <= N; i++)
            {
                meio = i * i;
                fim = meio * i;

                Console.WriteLine(i + " " + meio + " " + fim);

            }
        }
    }
}