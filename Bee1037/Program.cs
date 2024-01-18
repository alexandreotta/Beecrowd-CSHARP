using System;
using System.Globalization;

namespace Bee1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            string intervalo;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (N >= 0 && N <= 25)
            {
                intervalo = "(0,25]";
                Console.WriteLine("Intervalo " + intervalo);
            }
            else if (N >= 25 && N <= 50)
            {
                intervalo = "(25,50]";
                Console.WriteLine("Intervalo " + intervalo);
            }
            else if (N >= 50 && N <= 75)
            {
                intervalo = "(50,75]";
                Console.WriteLine("Intervalo " + intervalo);
            }
            else if (N >= 75 && N <= 100)
            {
                intervalo = "(75,100]";
                Console.WriteLine("Intervalo " + intervalo);
            }
            else
            {
                Console.Write("Fora de intervalo ");
            }
        }
    }
}
