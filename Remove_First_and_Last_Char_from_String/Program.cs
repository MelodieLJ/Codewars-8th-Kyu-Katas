using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Challenge: Create a function that removes the first and last characters of a string. You're given one parameter, the original string. You don't have to worry with strings with less than two characters.
namespace Remove_First_and_Last_Char_from_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.RemoveChar("Melly"));
        }
    }

    public static class Kata
    {
        public static string RemoveChar(string s)
        {
            //create a temporary char array to store the string
            //char[] temp = s.ToCharArray();

            //convert the char arry to a List
            //List<char> temp1 = temp.ToList();

            //temp1.RemoveAt(0);
            //temp1.RemoveAt(temp1.Count - 1);

            //Return the newly modified List as a string
            //return new string(temp1.ToArray());


            return s.Remove(s.Count() - 1).Remove(0, 1);
        }
    }
}
