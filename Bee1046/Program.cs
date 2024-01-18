using System;
using System.Globalization;

namespace Bee1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int HoraInicial, HoraFinal, duracao;

            string[] vet = Console.ReadLine().Split(' ');

            HoraInicial = int.Parse(vet[0]);
            HoraFinal   = int.Parse(vet[1]);

            if (HoraInicial < HoraFinal)
            {
                duracao = HoraFinal - HoraInicial; 
            }
            else
            {
                duracao = 24 - HoraInicial + HoraFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}