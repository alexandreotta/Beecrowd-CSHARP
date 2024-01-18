using System;
using System.Globalization;

namespace Bee1047
{
    class Program
    {
        static void Main(string[] args)
        {

            int HoraInicial, MinutoInicial, HoraFinal, MinutoFinal, duracao;

            string[] vet = Console.ReadLine().Split(' ');

            HoraInicial = int.Parse(vet[0]);
            MinutoInicial = int.Parse(vet[1]);
            HoraFinal = int.Parse(vet[2]);
            MinutoFinal = int.Parse(vet[3]);

            int instanteInicial = HoraInicial * 60 + MinutoInicial;
            int instanteFinal = HoraFinal * 60 + MinutoFinal;

            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + "MINUTO(S)");
        }
    }
} 
   