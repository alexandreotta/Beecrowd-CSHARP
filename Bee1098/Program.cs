using System;
using System.Globalization;

namespace Bee1098
{
    class Program
    {
        static void Main(string[] args)
        {

            double I = 0.0;

            while (I <= 2.0)
            {
                double J = I + 1.0;
                if (I == 0.0 || I == 1.0)
                {
                    for (int e = 0; e < 3; e++)
                    {
                        Console.WriteLine("I=" + I.ToString(CultureInfo.InvariantCulture) + " J=" + J.ToString(CultureInfo.InvariantCulture));
                        J++;
                    }
                }
                else
                {
                    for (int e = 0; e < 3; e++)
                    {
                        if (I > 1.9)
                        { 
                            Console.WriteLine("I=2 J=" + J.ToString(CultureInfo.InvariantCulture));
                            J++;
                        }
                        else
                        {
                            Console.WriteLine("I=" + I.ToString("F1", CultureInfo.InvariantCulture) + " J=" + J.ToString("F1", CultureInfo.InvariantCulture));
                            J++;
                        }
                    }
                }
                I += 0.2;
            }
        }
    }
}