using System;

namespace URI_1061
{
    class Program
    {
        static void Main(string[] args)
        {


            int W, X, Y, Z, resto, diaInicio, diaFinal, inicial, final, duracao;

            string[] dia = Console.ReadLine().Split(' ');
            diaInicio = int.Parse(dia[1]);

            string[] horas = Console.ReadLine().Split(':');
            int horaInicial = int.Parse(horas[0]);
            int minutoInicial = int.Parse(horas[1]);
            int segundoInicial = int.Parse(horas[2]);


            inicial = (int)(diaInicio - 1) * 24 * 60 * 60 + horaInicial * 60 * 60 + minutoInicial * 60 + segundoInicial;

            dia = Console.ReadLine().Split(' ');
            diaFinal = int.Parse(dia[1]);

            horas = Console.ReadLine().Split(':');
            int horaFinal = int.Parse(horas[0]);
            int minutoFinal = int.Parse(horas[1]);
            int segundoFinal = int.Parse(horas[2]);

            final = (int)(diaFinal - 1) * 24 * 60 * 60 + horaFinal * 60 * 60 + minutoFinal * 60 + segundoFinal;

            duracao = final - inicial;


            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);

            X = resto / (60 * 60);
            resto = resto % (60 * 60);

            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");
        }
    }
}