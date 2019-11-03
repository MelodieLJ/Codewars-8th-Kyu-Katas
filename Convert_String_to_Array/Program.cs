using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challenge: Write a function to split a string and convert it into an array of words.

namespace Convert_String_to_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Solution.StringToArray("Hello this is awesome")));
        }
    }

    public static class Solution
    {
        public static string[] StringToArray(string str)
        {
            string[] temp = str.Split(' ');
            return temp;

            //return str.Split(' ');
        }
    }
}
