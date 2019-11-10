using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challenge: Return the nth Even Number. E.g. NthEven(3) //=> 4, the 3rd even number is 4 (0, 2, 4)
namespace Return_nth_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output to be 2597466
            Console.WriteLine(Kata.NthEven(1298734));
        }
    }

    public static class Kata
    {
        public static int NthEven(int n)
        {
            return (n * 2) - 2;
        }
    }
}
