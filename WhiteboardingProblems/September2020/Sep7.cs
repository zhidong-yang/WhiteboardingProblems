using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep7
    {
        /*
         * Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

            Examples:

            solution('abc', 'bc') // returns true
            solution('abc', 'd') // returns false
         */
        public static bool Solution(string str, string ending)
        {
            // if the second string is longer than the first string, return false
            if (str.Length < ending.Length)
            {
                return false;
            }
            else
            {
                if (str.Substring(str.Length-ending.Length).CompareTo(ending) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
