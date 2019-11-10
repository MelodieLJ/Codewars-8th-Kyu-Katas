using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Challenge: Write function bmi that calculates body mass index (bmi = weight / height ^ 2).
//if bmi <= 18.5 return "Underweight"
//if bmi <= 25.0 return "Normal"
//if bmi <= 30.0 return "Overweight"
//if bmi > 30 return "Obese"
namespace Calculating_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Bmi(80, 1.80));
        }
    }

    public static class Kata
    {
        public static string Bmi(double height, double weight)
        {
            double bmi = weight / (height * height);

            if (bmi <= 18.5)
            {
                return "Underweight";
            }
            else if (bmi <= 25.0)
            {
                return "Normal";
            }
            else if (bmi <= 30.0)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }        
        }
    }
}
