using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.August2020
{
    public class Aug24
    {
        /*
         * The Fibonacci numbers are the numbers in the following integer sequence (Fn):

            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...

            such as

            F(n) = F(n-1) + F(n-2) with F(0) = 0 and F(1) = 1.

            Given a number, say prod (for product), we search two Fibonacci numbers F(n) and F(n+1) verifying

            F(n) * F(n+1) = prod.

            Your function productFib takes an integer (prod) and returns an array:

            [F(n), F(n+1), true] or {F(n), F(n+1), 1} or (F(n), F(n+1), True)
            depending on the language if F(n) * F(n+1) = prod.

            If you don't find two consecutive F(m) verifying F(m) * F(m+1) = prodyou will return

            [F(m), F(m+1), false] or {F(n), F(n+1), 0} or (F(n), F(n+1), False)
            F(m) being the smallest one such as F(m) * F(m+1) > prod.

            Some Examples of Return:
            (depend on the language)

            productFib(714) # should return (21, 34, true), 
                            # since F(8) = 21, F(9) = 34 and 714 = 21 * 34

            productFib(800) # should return (34, 55, false), 
                            # since F(8) = 21, F(9) = 34, F(10) = 55 and 21 * 34 < 800 < 34 * 55
            -----
            productFib(714) # should return [21, 34, true], 
            productFib(800) # should return [34, 55, false], 
            -----
            productFib(714) # should return {21, 34, 1}, 
            productFib(800) # should return {34, 55, 0},        
            -----
            productFib(714) # should return {21, 34, true}, 
            productFib(800) # should return {34, 55, false}, 
         * 
         */
        private static ulong Fib(ulong n)
        {
            ulong output;
            Dictionary<ulong, ulong> fibRef = new Dictionary<ulong, ulong>();

            if (n == 0 || n == 1)
            {
                return n;
            }

            if (fibRef.ContainsKey(n))
            {
                return fibRef[n];
            }

            output = Fib(n - 1) + Fib(n - 2);
            fibRef[n] = output;

            return output;
        }
        public static ulong[] ProductFib(ulong input)
        {
            ulong[] output = new ulong[3];
            ulong trialNum = 0;

            while (Fib(trialNum) * Fib(trialNum + 1) < input)
            {
                trialNum++;
            }
            output[0] = Fib(trialNum);
            output[1] = Fib(trialNum + 1);

            if (Fib(trialNum) * Fib(trialNum + 1) == input)
            {
                output[2] = 1;
            }
            else
            {
                output[2] = 0;
            }

            return output;
        }
    }
}
