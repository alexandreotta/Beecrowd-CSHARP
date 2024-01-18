using System;
using System.Globalization;

namespace Problema1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            double Raio = double.Parse(Console.ReadLine());

            double volume = (4 / 3.0) * pi * Math.Pow(Raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}