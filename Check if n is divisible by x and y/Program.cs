using System;

namespace Check_if_n_is_divisible_by_x_and_y
{
    //Challenge: Create a function that checks if a number n is divisible by two numbers x AND y.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.isDivisible(12,3,4));
        }
    }

    public class Kata
    {
        public static bool isDivisible(long n, long x, long y)
        {
            if (n % x == 0 && n % y == 0)
            {
                return true;
            }
            return false;
        }
    }
}
