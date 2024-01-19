using System;

namespace Bee1172
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vet;
            vet = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i] <= 0)
                {
                    vet[i] = 1;
                }
            }

            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine("X[{0}] = {1}", i, vet[i]);
            }
           
        }
    }
}