using System;
using System.Globalization;

namespace Problema1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, ano, mes, dia, resto, valor;

            idade = int.Parse(Console.ReadLine());

            ano = 365;
            valor = idade / ano;
            Console.WriteLine(valor + " ano(s)");
            resto = idade % ano;

            mes = 30;
            valor = resto / mes;
            Console.WriteLine(valor + " mes(es)");
            resto = resto % mes;

            dia = 1;
            valor = resto / dia;
            Console.WriteLine(valor + " dia(s)");


        }
    }
}