using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise5
    {
        public static void Exponentiation()
        {
            for ( int i = 1; i < 21; i++ )
            {
                Console.WriteLine( i + "^3 = " + Math.Pow(i, 3));
            }
        }
    }
}
