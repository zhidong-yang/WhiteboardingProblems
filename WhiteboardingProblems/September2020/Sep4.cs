using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep4
    {
        /*
         * There is a queue for the self-checkout tills at the supermarket. Your task is write a function 
         * to calculate the total time required for all the customers to check out!

          Input:
          customers: an array of positive integers representing the queue. Each integer represents a customer, and its value is 
          the amount of time they require to check out.
          n: a positive integer, the number of checkout tills.
          Output:
          The function should return an integer, the total time required.
          Examples:
          queueTime([5,3,4], 1)
            // should return 12
            // because when there is 1 till, the total time is just the sum of the times

          queueTime([10,2,3,3], 2)
            // should return 10
            // because here n=2 and the 2nd, 3rd, and 4th people in the 
            // queue finish before the 1st person has finished.

          queueTime([2,3,10], 2)
            // should return 12

        Clarifications
            There is only ONE queue serving many tills, and
            The order of the queue NEVER changes, and
            The front person in the queue (i.e. the first element in the array/list) proceeds to a till as soon as it becomes free.
            N.B. You should assume that all the test input will be valid, as specified above.

            P.S. The situation in this kata can be likened to the more-computer-science-related idea of a thread pool, with 
            relation to running multiple processes at the same time: https://en.wikipedia.org/wiki/Thread_pool
         */

        public static long QueueTime(int[] customers, int n)
        {
            long output;

            if (customers.Length == 0)
            {
                output = 0;
            }
            // if customers.Length < n, return the biggest value in the array of customers
            else if (customers.Length < n)
            {
                output = customers.Max();
            }

            // else, while the customers array is not empty, continue to dequeue the number to the smallest total value of each till
            else
            {
                Queue<int> customerQueue = new Queue<int>();
                for(int i = 0; i < customers.Length; i++)
                {
                    customerQueue.Enqueue(customers[i]);
                }

                // use an array to keep track of each till's total time
                int[] tillTime = new int[n];
                while (customerQueue.Count > 0)
                {
                    int minValueIndex = Array.IndexOf(tillTime, tillTime.Min());
                    tillTime[minValueIndex] += customerQueue.Dequeue();
                }

                output = tillTime.Max();
            }

            return output;
        }
    }
}
