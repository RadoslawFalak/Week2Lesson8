using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise1
    {
        public static void HowManyPrimeNumbers()
        {
            int n = 0;
            for(int i = 2; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        n++;
                    }
                }
                if (n == 0)
                {
                    Console.WriteLine(i);  
                }
                n = 0;
            }
        }
    }
}
