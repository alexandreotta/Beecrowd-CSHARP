using System;
using System.Globalization;

namespace Bee1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int peca, quant;
            double preco;
            double total;

            string[] s = Console.ReadLine().Split(' ');
            
            peca = int.Parse(s[0]);
            quant = int.Parse(s[1]);
            preco = double.Parse(s[2], CultureInfo.InvariantCulture);

            total = (double) quant * preco;

            string[] s1 = Console.ReadLine().Split(' ');

            peca = int.Parse(s1[0]);
            quant = int.Parse(s1[1]);
            preco = double.Parse(s1[2], CultureInfo.InvariantCulture);

            total = total + quant * preco;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
