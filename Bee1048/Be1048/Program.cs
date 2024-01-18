using System;
using System.Globalization;

namespace Bee1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double percentual, novosalario, reajuste;

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.0) 
            {
                percentual = 15.0;
                novosalario = salario + salario * percentual / 100.0;
                reajuste = novosalario - salario;
            } 
            else if (salario <= 800.0)
            {
                 percentual = 12.0;
                 novosalario = salario + salario * percentual / 100.0;
                 reajuste = novosalario - salario;
            }       
            else if (salario <= 1200.0)
            {
                percentual = 10.0;
                novosalario = salario + salario * percentual / 100.0;
                reajuste = novosalario - salario;
            }  
            else if (salario <= 2000.0)
            {
                percentual = 7.0;
                novosalario = salario + salario * percentual / 100.0;
                reajuste = novosalario - salario;
            }
            else
            {
                percentual = 4.0;
                novosalario = salario + salario * percentual / 100.0;
                reajuste = novosalario - salario;
            }

            Console.WriteLine("Novo Salario: " + novosalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste Ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
                 
        }
    }
}