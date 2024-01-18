using System;
using System.Globalization;

namespace Be1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, media, notaexame, mediafinal;

            string[] vet = Console.ReadLine().Split(' ');

            N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (N1 * 2.0 + N2 * 3.0 + N3 * 4.0 + N4 * 1) / 10.0;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaexame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaexame.ToString("F1", CultureInfo.InvariantCulture));
                mediafinal = (notaexame + media) / 2.0;

                    if (mediafinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado");
                    Console.WriteLine("Media final: " + mediafinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                    else
                {
                    Console.WriteLine("Aluno reprovado");
                    Console.WriteLine("Media final: " + mediafinal.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}