using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep5
    {
        /*
         * Given two numbers and an arithmetic operator (the name of it, as a string), return the result of the two numbers having that 
         * operator used on them.

         a and b will both be positive integers, and a will always be the first number in the operation, and b always the second.

         The four operators are "add", "subtract", "divide", "multiply".

         A few examples:

         Kata.Arithmetic(5, 2, "add")      => 7
         Kata.Arithmetic(5, 2, "subtract") => 3
         Kata.Arithmetic(5, 2, "multiply") => 10
         Kata.Arithmetic(5, 2, "divide")   => 2.5
         Try to do it without using if statements!
         */

        public static double Arithmetic(double a, double b, string op)
        {
            // Not using if statements
            // Get all the results from four calculations and put them in a dictionary
            // Find corresponding element and return

            Dictionary<string, double> output = new Dictionary<string, double>(); 
            try
            {                               
                output["add"] = a + b;
                output["subtract"] = a - b;
                output["multiply"] = a * b; 
                output["divide"] = a / b;                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("A number cannot be divided by zero.");
            }

            return output[op];
        }

    }
}
