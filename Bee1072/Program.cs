using System;

namespace Bee1072
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int N = int.Parse(Console.ReadLine());
            int contF = 0;
            int contD = 0;
            int X = 0;

            for (int i = 1; i <= N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    contD = contD + 1;
                }
                else
                {
                    contF = contF + 1;
                }
            }

            Console.WriteLine(contD + " in");
            Console.WriteLine(contF + " out");
        }
    }
}