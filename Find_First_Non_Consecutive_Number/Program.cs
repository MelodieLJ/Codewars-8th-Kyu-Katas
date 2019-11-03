using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Challenge: Return first non consecutive number in an array
namespace Find_First_Non_Consecutive_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FirstNonConsecutive(new int[] { 1,2,3,4,6,7,8}));
        }
    }

    public static class Kata
    {
        public static object FirstNonConsecutive(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 != arr[i + 1])
                {
                    return arr[i + 1];
                }
            }
            //If the array is completly consecutive, return nothing
            return "nothing";
        }
    }

}
