using System;
using System.Globalization;

namespace Problema1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int combustivel = 12;

            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            int distancia = tempo * velocidade;

            double litros = (double)distancia / combustivel;

            Console.WriteLine(litros.ToString("F3",CultureInfo.InvariantCulture));

        }
    }
}