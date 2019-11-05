using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challenge: Create a function that takes a string and inverts the letters from uppercase to lowercase or vice versa

namespace Alternating_Upper_or_Lower_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringExt.ToAlternatingCase("HeLLO WOrLD"));
        }
    }

    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            char[] temp = s.ToCharArray();
            List<char> result = new List<char>();

            foreach (var item in temp)
            {
                if (item == Char.ToUpper(item))
                {
                    result.Add(Char.ToLower(item));
                }
                else
                {
                    result.Add(Char.ToUpper(item));
                }
            }

            return new string(result.ToArray());
        }
    }
}
