using System;
using System.Linq;

namespace Sum_of_ints_and_letters
{
    //Challenge: Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers. Return your answer as a number.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.SumMix(new object[] { 9,3, "7", "3"}));
        }
    }


    public class Kata
    {
        public static int SumMix(object[] x)
        {
            int sum = 0;
            foreach (var item in x)
            {
                int each = Convert.ToInt32(item);
                sum += each;
            }

            return sum;

           // return x.Sum(Convert.ToInt32);

        }
    }
}
