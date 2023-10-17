using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise1
    {
        public static void HowManyNumbers()
        {
            int a = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i > 1 && i %1 == 0 && i %i == 0)
                {
                    a++;
                }             
            }
            Console.WriteLine(a);
        }
    }
}
