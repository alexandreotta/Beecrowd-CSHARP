using System;
using System.Globalization;

namespace Bee1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos;
            double soma, media;

            double N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double N4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double N5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double N6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            positivos = 0;
            soma = 0;

            if (N1 > 0)
            {
                positivos += 1;
                soma += N1;

                if (N2 > 0)
                {
                    positivos += 1;
                    soma += N2;
                }
                if (N3 > 0)
                {
                    positivos += 1;
                    soma += N3;
                }
                if (N4 > 0)
                {
                    positivos += 1;
                    soma += N4;
                }
                if (N5 > 0)
                {
                    positivos += 1;
                    soma += N5;
                }
                if (N6 > 0)
                {
                    positivos += 1;
                    soma += N6;
                }

                media = soma / positivos;

                Console.WriteLine(positivos + " valores positivos");
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}