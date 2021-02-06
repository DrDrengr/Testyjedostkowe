using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium
{
    public class NaturalPowerCalculator : ITwoNaturalNumbersMatchOperation
    {
        public int Calculate(int numberA, int numberB)
        {
            if (numberA >= 0 && numberB >= 0)
            {
                if (numberB == 0)
                {
                    return 1;
                }
                else if (numberB == 1)
                {
                    return numberA;
                }
                else
                {
                    return numberA * Calculate(numberA, numberB - 1);
                }
            }
            else
            {
                return 0;
            }
        }

        public void Console()
        {
            int A, B;
            System.Console.WriteLine("Podaj podstawe:");
       
            if (!int.TryParse(System.Console.ReadLine(), out A))
            {
                System.Console.WriteLine("Błędne dane");
            }
            System.Console.WriteLine("Podaj wykładnik:");
            if (!int.TryParse(System.Console.ReadLine(), out B))
            {
                System.Console.WriteLine("Błędne dane");
            }

            System.Console.WriteLine("Wynik:");

            System.Console.WriteLine(Calculate(A,B));
        }
    }
}
