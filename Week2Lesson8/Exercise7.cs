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
            int p = 2;
            int q = 0;
            int z = 2;

            for (int k = 0; k < userNumber / 2 + 1; k++)
            {
                for (int i = 0; i < userNumber / 2 - k; i++)
                {
                    Console.Write(" ");
                }
                if (k == 0)
                {
                    Console.Write("*");
                }
                if (k != 0)
                {
                    for (int j = 0; j < k + p; j++)
                    {
                        Console.Write("*");
                    }
                    p += 1;
                }
                Console.WriteLine();
            }
            for (int k = userNumber / 2; k > 0; k--)
            {
                for (int i = 0; i < 1 + q; i++)
                {
                    Console.Write(" ");
                }
                q++;
                if (k == 1)
                {
                    Console.Write("*");
                }
                if (k != 1)
                {
                    for (int j = 0; j < userNumber - z; j++)
                    {
                        Console.Write("*");
                    }
                    z += 2;
                }
                Console.WriteLine();
            }




















            /*for (int i = 1; i <= userNumber; i++)
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
          } */
        }
    }
}
/*---*---
  --***--
  -*****-
  ********/
