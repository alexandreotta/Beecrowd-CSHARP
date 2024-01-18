using System;
using System.Globalization;

namespace Uri1154
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0.0;
            double soma = 0.0;
            double cont = 0.0;
            double idade = double.Parse(Console.ReadLine());

            while (idade > 0)
            {
                soma = idade + soma;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine());
            }
            media = soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

