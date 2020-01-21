using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Vowels
{

    //Challenge: Create a function called shortcut to remove all the vowels in a given string.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Shortcut("hello world"));
        }
    }

    public class Kata
    {
        public static string Shortcut(string input)
        {
            string vowel = "aeiou";

            List<char> temp = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!vowel.Contains(input[i]))
                {
                    temp.Add(input[i]);
                }
            }

            return new string(temp.ToArray());
            
        }
    }
}
