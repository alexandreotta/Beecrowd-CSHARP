using System;
using System.Globalization;

namespace Bee1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, perimetro, area;

            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (A + B > C && B + C > A && C + A > B)
            {
                perimetro = (A + B + C);
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) * C / 2.0);
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}