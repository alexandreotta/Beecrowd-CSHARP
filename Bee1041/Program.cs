﻿using System;
using System.Globalization;

namespace Bee1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y;

            string[] vet = Console.ReadLine().Split(' ');

            X = double.Parse(vet[0]);
            Y = double.Parse(vet[1]);

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (X == 0 && Y != 0 )
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Y == 0 && X != 0)
            {
                Console.WriteLine("Eixo X");
            }
            else
            {
                Console.WriteLine("Origem");
            }                    
        }
    }
}