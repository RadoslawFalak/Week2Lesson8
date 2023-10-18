using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise6
    {
        public static void Fractions()
        {
            double number = 0;
            for (int i = 1; i <= 20; i++)
            {               
                number += 1.0 / i;              
            }
            Console.WriteLine(Math.Round(number, 3));
        } 
    }
}
