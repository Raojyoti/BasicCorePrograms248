using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// Alphabet class is created to Check Whether an Alphabet is Vowel or Consonant
    /// </summary>
    public class Alphabet
    {
        static char alphabet;
        public static void CheckAlphabetIsVowelOrConsonant()
        {
            Console.WriteLine("Please enter alphabet to check is vowel or consonant");
            alphabet=Convert.ToChar(Console.ReadLine().ToLower());
            switch(alphabet) 
            { 
                case 'a': Console.WriteLine("{0} is vowel", alphabet);
                    break;
                case 'e':
                    Console.WriteLine("{0} is Vowel", alphabet);
                    break;
                case 'i':
                    Console.WriteLine("{0} is vowel", alphabet);
                    break;
                case 'o':
                    Console.WriteLine("{0} is vowel", alphabet);
                    break;
                case 'u':
                    Console.WriteLine("{0} is vowel", alphabet);
                    break;
                default:
                    Console.WriteLine("{0} is Consonant", alphabet);
                    break;
            }
        }

    }
}
