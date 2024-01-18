using System;
using System.Globalization;


namespace Bee1094
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            string Tiipo;
            int Quantia = 0;
            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;
            double soma = 0.0;
            double PerC, PerR, PerS;
            

            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                Quantia = int.Parse(vet[0]);
                Tiipo = vet[1];

                if (Tiipo == "C")
                {
                    coelhos = coelhos + Quantia;
                }
                else if (Tiipo == "R")
                {
                    ratos = ratos + Quantia;
                }
                else
                {
                    sapos = sapos + Quantia;
                }

                soma = sapos + coelhos + ratos;
            }

            PerC = coelhos / soma * 100;
            PerR = ratos / soma * 100;
            PerS = sapos / soma * 100;

            Console.WriteLine("Total: "+soma+" cobaias");
            Console.WriteLine("Total de coelhos: "+coelhos);
            Console.WriteLine("Total de ratos: "+ratos);
            Console.WriteLine("Total de sapos: "+sapos);

            Console.WriteLine("Percentual de coelhos: "+PerC.ToString("F2", CultureInfo.InvariantCulture)+" %");
            Console.WriteLine("Percentual de ratos: "+PerR.ToString("F2", CultureInfo.InvariantCulture)+" %");
            Console.WriteLine("Percentual de sapos: "+PerS.ToString("F2", CultureInfo.InvariantCulture)+" %");
        }
    }
}