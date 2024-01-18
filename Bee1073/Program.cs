using System;

namespace Bee1073
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            double soma = 0;

            for (int i = 1; i <= N; i++)
            {

                if (i % 2 == 0)
                {
                    soma = Math.Pow(i,2);
                    Console.WriteLine(i+"^"+2+" = "+soma);
                }
            }
        }
    }
}