using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challemge: Create a function that removes the first and last characters of a string.
namespace Remove_First_and_Last_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.RemoveChar("Removing"));
        }
    }

    public static class Kata
    {
        public static string RemoveChar(string s)
        {
            //create a temporary char array to hold the string
            char[] temp = s.ToCharArray();
            //convert the char array to a List
            List<char> secondString = temp.ToList();

            //Remove the first item
            secondString.RemoveAt(0);
            //Remove the last item
            secondString.RemoveAt(secondString.Count - 1);

            //return the List as a new string
            return new string(secondString.ToArray());

            //return s.Remove(s.Length - 1).Remove(0, 1);
        }
    }
}
