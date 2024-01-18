using System;
using System.Globalization;

namespace Bee159
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int soma = 0;

            while (x != 0)
            {
                soma = x + soma;

                if (x % 2 == 0)
                {
                    soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                    Console.WriteLine(soma);
                    x = int.Parse(Console.ReadLine());
                }
                else
                {
                    x = x + 1;
                    soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                    Console.WriteLine(soma);
                    x = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}