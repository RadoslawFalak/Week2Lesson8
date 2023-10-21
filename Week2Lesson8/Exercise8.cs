using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise8
    {
        public static void Reverse()
        {
            string word = Console.ReadLine();
            char[] characters = word.ToCharArray();                         

            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (i == word.Length - 1)
                {
                    Console.Write(char.ToUpper(characters[i]));
                }
                else
                {
                    Console.Write(char.ToLower(characters[i]));
                }
            }                         
        }
    }
}
