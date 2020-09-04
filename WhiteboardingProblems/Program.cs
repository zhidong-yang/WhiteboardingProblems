using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteboardingProblems.September2020;

namespace WhiteboardingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNum = { 3, 14, 26, 28, 7, 2, 33, 27, 33, 6, 45, 15, 14, 13, 2, 6, 11, 5, 30, 45, 20, 31, 22, 39, 31, 24, 8 };
            int n = 5;

            Console.WriteLine(Sep4.QueueTime(arrayOfNum, n));
            Console.ReadLine();
        }

    }
}
