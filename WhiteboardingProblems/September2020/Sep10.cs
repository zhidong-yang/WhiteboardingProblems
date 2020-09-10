using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep10
    {
        /*
        Some numbers have funny properties.For example:

            89 --> 8¹ + 9² = 89 * 1

            695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2

            46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51

            Given a positive integer n written as abcd... (a, b, c, d...being digits) and a positive integer p

            we want to find a positive integer k, if it exists, such as the sum of the digits of n taken to the successive powers of p is equal to k* n.
            In other words:

            Is there an integer k such as : (a ^ p + b ^ (p+1) + c ^(p+2) + d ^ (p+3) + ...) = n* k

            If it is the case we will return k, if not return -1.

            Note: n and p will always be given as strictly positive integers.

            digPow(89, 1) should return 1 since 8¹ + 9² = 89 = 89 * 1
            digPow(92, 1) should return -1 since there is no k such as 9¹ + 2² equals 92 * k
            digPow(695, 2) should return 2 since 6² + 9³ + 5⁴= 1390 = 695 * 2
            digPow(46288, 3) should return 51 since 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51

        */

        public static long digPow(int n, int p)
        {
            Stack<int> digits = new Stack<int>();
            int shavedN = n;
            while (shavedN > 0)
            {
                int nextDigit = shavedN % 10;
                digits.Push(nextDigit);
                shavedN = shavedN / 10;
            }

            long sumOfDigits = 0;

            while (digits.Count != 0)
            {
                sumOfDigits += Convert.ToInt64(Math.Pow(digits.Pop(), p));
                p = p + 1;
            }

            if (sumOfDigits % n == 0)
            {
                return sumOfDigits / n;
            }
            else
            {
                return -1;
            }
        }
    }
}
