using System;
using System.Globalization;

namespace Problema1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int PesoA = 2;
            int PesoB = 3;
            int PesoC = 5;

            double media = (A * PesoA + B * PesoB + C * PesoC) / (PesoA + PesoB + PesoC);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
