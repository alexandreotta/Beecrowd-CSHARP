using System;
using System.Collections;
using System.Globalization;
using System.Xml;

namespace Problema1021
{
    class Program
    {
        static void Main(string[] args)
        {

            double nota, quociente, resto, moeda;

            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = N / nota;
            resto = N % nota;
            Console.WriteLine((int) quociente + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));

            nota = 50;
            quociente = resto / nota;
            resto = resto % nota;
            Console.WriteLine((int)quociente + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));

            nota = 20;
            quociente = resto / nota;
            resto = resto % nota;
            Console.WriteLine((int)quociente + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));

            nota = 10;
            quociente = resto / nota;
            resto = resto % nota;
            Console.WriteLine((int)quociente + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));

            nota = 5;
            quociente = resto / nota;
            resto = resto % nota;
            Console.WriteLine((int)quociente + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture)); 
            nota = 2;
            quociente = resto / nota;
            resto = resto % nota;
            Console.WriteLine((int)quociente + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("MOEDAS:");

            moeda = 1.0;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture)); 

            moeda = 0.5;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture)); 

            moeda = 0.25;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture)); 

            moeda = 0.10;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture)); 

            moeda = 0.05;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture)); 

            moeda = 0.01;
            quociente = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)quociente + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}