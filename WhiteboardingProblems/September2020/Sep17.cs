using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep17
    {
        /*
         * Your task is to construct a building which will be a pile of n cubes. The cube at the bottom will have a volume of n^3, the cube above 
         * will have volume of (n-1)^3 and so on until the top which will have a volume of 1^3.

            You are given the total volume m of the building. Being given m can you find the number n of cubes you will have to build?

            The parameter of the function findNb (find_nb, find-nb, findNb) will be an integer m and you have to return the integer n such as n^3 + (n-1)^3 + ... + 1^3 = m if such a n exists or -1 if there is no such n.

            Examples:
            findNb(1071225) --> 45
            findNb(91716553919377) --> -1
            mov rdi, 1071225
            call find_nb            ; rax <-- 45

            mov rdi, 91716553919377
            call find_nb            ; rax <-- -1
         */

        public static long FindNb(long m)
        {
            long output = 1;
            long sumOfCub = 0;
            while (sumOfCub < m)
            {
                sumOfCub += Convert.ToInt64(Math.Pow(output, 3));
                output++;
            }

            if (sumOfCub == m)
            {
                return output - 1;
            }
            else
            {
                return -1;
            }
        }

    }
}
