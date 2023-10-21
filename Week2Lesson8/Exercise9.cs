using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise9
    {
        public static void DecimalToBinary()
        {
            int decimalUserNumber;
            string input = Console.ReadLine();
            int.TryParse(input, out decimalUserNumber);
            string binary = "";
            int intToString;
            string modulo;

            while (decimalUserNumber != 0)
            {
                //Console.WriteLine(decimalUserNumber + " / 2 = " + decimalUserNumber / 2); // spradznie poprawnosci dzielenia
                //Console.WriteLine("modulo = " + decimalUserNumber %2); // spradzenie poprawnosi operacji modulo
                intToString = decimalUserNumber % 2;
                decimalUserNumber = decimalUserNumber / 2;
                
                modulo = intToString.ToString();
                binary = binary + modulo;               
            }
            // Console.WriteLine(binary); // sprawdzenie czy liczba prawidlowo zapisala sie do stringa 
            char[] characters = binary.ToCharArray(); // zapis stringa to tabeli char
            
            for (int i = characters.Length - 1; i >= 0; i--) // wypisanie tabeli char od tylu
            {
                Console.Write(characters[i]);
            }
        }
    }
}
