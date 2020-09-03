using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep3
    {
        /*
         * ake 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing distinct letters,

           each taken only once - coming from s1 or s2.
           Examples:
           a = "xyaabbbccccdefww"
           b = "xxxxyyyyabklmopq"
           longest(a, b) -> "abcdefklmopqwxy"

           a = "abcdefghijklmnopqrstuvwxyz"
           longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"
         */

        public static string UniqueCombinedString(string s1, string s2)
        {
            HashSet<char> uniqueLetters = new HashSet<char>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (!uniqueLetters.Contains(s1[i]))
                {
                    uniqueLetters.Add(s1[i]);
                }
            }

            for (int j = 0; j < s2.Length; j++)
            {
                if (!uniqueLetters.Contains(s2[j]))
                {
                    uniqueLetters.Add(s2[j]);
                }
            }
            
            char[] charArray = new char[uniqueLetters.Count];
            // copy the values in the hashset to array
            uniqueLetters.CopyTo(charArray);
            // sort the array
            Array.Sort(charArray);
            // build the string
            StringBuilder resultString = new StringBuilder();
            foreach (var item in charArray)
            {
                resultString.Append(item);
            }

            string output = resultString.ToString();

            return output;

        }
    }
}
