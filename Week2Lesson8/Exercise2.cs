using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise2
    {
        public static void EvenNumbers()
        {
            int i = 0;

            do 
            {
                if ( i %2 == 0 && i != 0 )
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 1000);
        }
    }
}
