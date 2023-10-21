using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise7
    {
        public static void Diamond()
        {
            int userNumber;
            string input = Console.ReadLine();
            int.TryParse(input, out userNumber);

            for (int i = 1; i <= userNumber; i++)
            {               
                for (int j = 1; j <= userNumber; j++)
                {
                   int leftSpace= (userNumber - i) / 2;
                   int rightSpace = ((userNumber - i) / 2) + i;
                    
                    if (leftSpace >= j || rightSpace < j)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    
                }
                Console.WriteLine("");
            }
            for (int i = userNumber - 1; i >= 1; i--)
            {
                for (int j = 1; j <= userNumber; j++)
                {
                    int leftSpace = (userNumber - i) / 2;
                    int rightSpace = ((userNumber - i) / 2) + i;

                    if (leftSpace >= j || rightSpace < j)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine("");
            }
        }
    }
}
/*---*---
  --***--
  -*****-
  ********/
