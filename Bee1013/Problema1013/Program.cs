using System;
using System.Globalization;

namespace Problema1013
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);

            int MaiorAB = (A + B + Math.Abs(A - B)) / 2;

            int MaiorAC = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine(MaiorAC + " eh o maior");

            


        }
    }
}