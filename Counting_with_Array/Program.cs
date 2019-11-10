using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challenge: Given the number (n), populate an array with all numbers up to and including that number, but excluding zero.

namespace Counting_with_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", Kata.MonkeyCount(10)));
        }
    }

    public static class Kata
    {
        public static int[] MonkeyCount(int n)
        {
            List<int> temp = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                temp.Add(i);
            }

            return temp.ToArray();
        }
    }
}
