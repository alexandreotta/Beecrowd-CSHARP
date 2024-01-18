using System;
using System.Globalization;


namespace Bee1116
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int X, Y;
            double soma;

            for (int i = 1; i <= N; i++)
            {

                string[] vet = Console.ReadLine().Split(' ');

                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    soma = (double)X / Y;
                    Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}