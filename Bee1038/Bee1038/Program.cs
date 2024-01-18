using System;
using System.Globalization;

namespace Bee1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double quantidade, preco;

            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = double.Parse(vet[1], CultureInfo.InvariantCulture);

            switch (codigo)
            {
                case 1:
                    preco = 4.0;
                    preco *= quantidade;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    preco = 4.5;
                    preco *= quantidade;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    preco = 5.0;
                    preco *= quantidade;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    preco = 2.0;
                    preco *= quantidade;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    preco = 1.5;
                    preco *= quantidade;
                    Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }


        }
    }
}