using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise3
    {
        public static void Fibonacci()
        {
            int a = -1;
            int b = 1;
            int c = 0;
            for (int i = 0; i < 13; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(b); // 0,1,1,2,3,5,8,13,21,34,55,89,144   
            }           
        }
    }
}
