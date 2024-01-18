using System;
using System.Globalization;

namespace Bee1134
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int prod = int.Parse(Console.ReadLine());
            int diesel = 0;
            int gasolina = 0;
            int alcool = 0;

            while (prod != 4)
            {
                if (prod == 1)
                {
                    alcool = alcool + 1;
                    prod = int.Parse(Console.ReadLine());
                }
                else if (prod == 2)
                {
                    gasolina = gasolina + 1;
                    prod = int.Parse(Console.ReadLine());
                }
                else if (prod == 3)
                {
                    diesel = diesel + 1;
                    prod = int.Parse(Console.ReadLine());
                }
                else
                {
                    prod = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("MUITO OBRIGADO");

            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}