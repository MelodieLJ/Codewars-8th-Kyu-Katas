using System;
using System.Linq;

namespace Array_plus_Array
{

    //Challenge: Return the Sum of the elements of two arrays
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
        }
    }

    public static class Kata
    {
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            //simple solution using Linq
            return arr1.Sum() + arr2.Sum();
        }
    }
}
