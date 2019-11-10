using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Challenge: Create a function that counts the number of Sheep in an array where True = present
namespace Counting_Sheep_with_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.CountSheeps(new bool[] 
            { true,  true,  true,  false,
            true,  true,  true,  true,
            true,  false, true,  false,
            true,  false, false, true ,
            true,  true,  true,  true ,
            false, false, true,  true}
            ));
        }
    }

    public static class Kata
    {
        public static int CountSheeps(bool[] sheep)
        {
            //int count = 0;

            //foreach (var item in sheep)
            //{
            //    if (item == true)
            //    {
            //        count++;
            //    }
            //}

            //return count;

            return sheep.Count(s => s == true);
        }
    }
}
