using System;
using System.Globalization;

namespace Bee1015
{
    class Program
    {
        static void Main(string[] args)
        {

            double X1, X2, Y1, Y2, distancia;

            string[] s = Console.ReadLine().Split(' ');

            X1 = double.Parse(s[0], CultureInfo.InvariantCulture);
            Y1 = double.Parse(s[1], CultureInfo.InvariantCulture);

            string[] s1 = Console.ReadLine().Split(' ');

            X2 = double.Parse(s1[0], CultureInfo.InvariantCulture);
            Y2 = double.Parse(s1[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}