using System;
using System.Globalization;

namespace Problema1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double distancia = X / Y;

            Console.WriteLine(distancia.ToString("F3") + " km/l", CultureInfo.InvariantCulture);


        }
    }
}
