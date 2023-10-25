using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise10
    {
        static int LeastCommonDivisor(int a, int b)
        {
            while (a != b)
            {
                if (a < b)
                {
                    b -= a;
                }
                else
                {
                    a -= b;
                }
            }
            return a;
        }

        public static void LeastCommonMultiple() 
        {
            int numberOne;
            int numberTwo;
            Console.WriteLine("Najmniejsza wspolna wielokrotnosc dwoch liczb.");
            Console.Write("Podaj pierwsza liczbe: ");
            string input = Console.ReadLine();
            int.TryParse(input, out numberOne);
            Console.Write("Podaj pierwsza liczbe: ");
            input = Console.ReadLine();
            int.TryParse(input, out numberTwo);
            int leastCommonDivisor = Exercise10.LeastCommonDivisor(numberOne, numberTwo);
            Console.WriteLine($"NWW({numberOne},{numberTwo}) = " + numberOne * numberTwo / leastCommonDivisor);
        }
    }
}
