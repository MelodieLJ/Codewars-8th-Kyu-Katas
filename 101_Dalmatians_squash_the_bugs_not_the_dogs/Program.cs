using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challenge: Your friend has been out shopping for puppies. He arrives back with multiple dogs, and you simply do not know how to respond!
//By repairing the function provided, you will find out exactly how you should respond, depending on the number of dogs he has.
//The number of dogs will always be a number and there will always be at least 1 dog.

namespace _101_Dalmatians_squash_the_bugs_not_the_dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.HowManyDalmatians(50));
        }
    }

    public static class Kata
    {
        public static string HowManyDalmatians(int n)
        {
            if (n <= 10) return "Hardly any";
            if (n <= 50) return "More than a handful!";
            if (n == 101) return "101 DALMATIONS!!!";
            return "Woah that's a lot of dogs!";
        }
    }
}
