using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, delta, R1, R2;

            String[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0) 

            {
                Console.WriteLine("Impossivel calcular");
            }

            else
            {
                R1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                R2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }


        }

        
    }
}