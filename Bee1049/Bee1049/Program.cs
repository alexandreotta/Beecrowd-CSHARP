using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Bee1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo1, tipo2, tipo3;

            tipo1 = Console.ReadLine();
            tipo2 = Console.ReadLine();
            tipo3 = Console.ReadLine();

            if (tipo1 == "vertebrado")
            {
                if (tipo2 == "ave")
                {
                    if (tipo3 == "carnivoro")
                    {
                        Console.WriteLine("Aguia");
                    }
                    else if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("Pomba");
                    }
                }
                else if (tipo2 == "mamifero")
                {
                    if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("Homem");
                    }
                    else if (tipo3 == "herbivoro")
                    {
                        Console.WriteLine("Vaca");
                    }
                }
            }
            else if (tipo1 == "invertebrado")
            {
                if (tipo2 == "inseto")
                {
                    if (tipo3 == "hematofago")
                    {
                        Console.WriteLine("Pulga");
                    }
                    else if (tipo3 == "herbivoro")
                    {
                        Console.WriteLine("Lagarta");
                    }
                }
                else if (tipo2 == "anelideo")
                {
                    if (tipo3 == "hematofago")
                    {
                        Console.WriteLine("Sanguessuga");
                    }
                    else if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("Minhoca");
                    }
                }
            }
















        }
    }
}
