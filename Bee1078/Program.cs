using System;
using System.Globalization;

namespace bee1078
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int N2;

            for (int i = 1; i <= 10; i++)
            {             
                N2 = N * i;
                Console.WriteLine(i+" x "+N+" = "+N2);
            }
        }
    }
}