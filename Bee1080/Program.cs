using System;

namespace Bee1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = int.Parse(Console.ReadLine());
            int posicao = 1;

            for (int i = 2; i <= 100; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X > maior)
                {
                    maior = X;
                    posicao = i;
                }

            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);

        }
    }
}