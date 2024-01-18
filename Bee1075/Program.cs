using System;
using System.Globalization;

namespace Bee1079
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            double X1, X2, X3, media;

            for (int i = 1; i <= N; i++)

            {
                string[] vet = Console.ReadLine().Split(' ');

                X1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                X2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                X3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = (X1 * 2.0 + X2 * 3.0 + X3 * 5.0) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
