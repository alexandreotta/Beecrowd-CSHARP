using System;

namespace Bee1164
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int soma = 0;
                int X = int.Parse(Console.ReadLine());

                for (int aux = 1; aux < X; aux++)
                {
                    if (X % aux == 0)
                    {
                        soma += aux;
                    }
                }

                if (soma == X)
                {
                    Console.WriteLine(X + " eh perfeito");
                }
                else
                {
                    Console.WriteLine(X + " nao eh perfeito");
                }
            }
        }
    }
}