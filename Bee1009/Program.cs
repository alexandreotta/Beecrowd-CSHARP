using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Problema1009
{
    class Program
    {
        static void Main(string[] args) { 
        
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double Bonus = vendas * 15 / 100;
            double total = Bonus + salario;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        
        
        
        }
    }
}