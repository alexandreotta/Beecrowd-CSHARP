using System;
using System.Globalization;

namespace Problema1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double PesoA = 3.5;
            double PesoB = 7.5;

            double media = (A * PesoA + B * PesoB) / (PesoA + PesoB);

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
            
        }
    }
}
