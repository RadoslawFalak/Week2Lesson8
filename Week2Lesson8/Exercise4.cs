using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise4
    {
        public static void Pyramid()
        {
            int a =  1;
            for(int i = 0; i < 4;  i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write(a + " ");
                    a++;
                }
                Console.WriteLine();
            }
        } 
    }
}
