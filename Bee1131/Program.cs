using System;
using System.Globalization;

namespace uri1113
{
    class Program
    {
        static void Main(string[] args)
        {

            int Novo = 1;
            int cont = 0;
            int somaIn = 0;
            int somaGr = 0;
            int empate = 0;
            int VInt = 0;
            int VGre = 0;


            while (Novo == 1)
            {
                string[] valores = Console.ReadLine().Split(' ');


                cont = cont + 1;
                int X = int.Parse(valores[0]);
                int Y = int.Parse(valores[1]);

                if (X > Y)
                {
                    VInt = VInt + 1;
                }
                else if (Y > X)
                {
                    VGre = VGre + 1;
                }
                else
                {
                    empate = empate + 1;
                } 

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                Novo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(cont + " grenais");
            Console.WriteLine("Inter:" + VInt);
            Console.WriteLine("Gremio:" + VGre);
            Console.WriteLine("Empates:" + empate);

            if (VInt > VGre)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
} 