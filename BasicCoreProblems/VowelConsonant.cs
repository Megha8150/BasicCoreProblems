using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class VowelConsonant
    {
        public static void vowelConsonant()
        {
            Console.WriteLine("Enter the Alphabet");
            char letter = Convert.ToChar(Console.ReadLine());

            if ((letter == 'a') || (letter == 'e') || (letter == 'i') || (letter == 'o') || (letter == 'u'))
            {
                Console.WriteLine(letter+ " is a vowel");
            }
            else
            {
                Console.WriteLine(letter + " ia a consonant");
            }
        }
    }
}
