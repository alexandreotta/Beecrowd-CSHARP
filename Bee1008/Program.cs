using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Exercicio02While
{
    class Program
    {
        static void Main(string[] args)
        {

            int cont = 0;
            int idade, soma = 0;
            double media = double.Parse(Console.WriteLine(CultureInfo.InvariantCulture));

            idade = int.Parse(Console.ReadLine());
            
            if (idade < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                
                while (idade > 0)
                {
                    soma = idade + soma;
                    cont = cont + 1;
                    idade = int.Parse(Console.ReadLine());
                }



                Console.WriteLine(cont);
                Console.WriteLine(soma);
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }


            
  















        }
    }
}
