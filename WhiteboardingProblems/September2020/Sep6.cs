using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep6
    {
        /*
            A manufacturer purchases fragile components that must be shipped using expensive containers. 
            The manufacturer agrees to provide customers with a free container of components for returning a certain number of containers 
            determine the maximum number of containers a customer can receive given a budget, the cost per container, and the number of 
            empty containers that must be returned for a free container. Assume each container is immediately emptied and returned for credit.
            Example:
            n=4
            cost=1
            m=2
            Start with a budget n=4 units of currency to buy containers at cost=1 unit each. The number of empty containers to return for 
            a free full container is m=2. First, buy 4 containers with the entire budget. Turn in those 4 containers for 2 more containers. 
            Turn in those 2 containers for one more. At this point, there are not enough funds or containers to receive another. 
            In total, 4+2+1=7 containers were obtained.
            Function Description: Complete the function maximumContainers. It has one parameter: string scenarios[n]: each string contains three 
            space-separated integers, starting budget, cost, and the number of containers to return for a full container.
            Print: int – for each test case the function must print an integer, the maximum number of containers the manufacturer can obtain, 
            each on a new line. No return value is expected.
          */

        public static void maximumContainers(List<string> scenarios)
        {
            List<int> output = new List<int>();

            // translate each component of the input into numbers
            foreach (var item in scenarios)
            {
                int firstSpaceIndex = item.IndexOf(' ');
                // length of the first number digits = index of the first space
                int budget = Convert.ToInt32(item.Substring(0, firstSpaceIndex));

                int secondSpaceIndex = item.IndexOf(' ', firstSpaceIndex + 1, item.Length - 1 - firstSpaceIndex);
                int cost = Convert.ToInt32(item.Substring(firstSpaceIndex + 1, secondSpaceIndex - firstSpaceIndex - 1));

                int freeContainerPrice = Convert.ToInt32(item.Substring(secondSpaceIndex + 1));

                int totalContainers = budget / cost;


                int remainderContainers = (budget / cost) % freeContainerPrice;

                int additionalRoundContainers = ((budget / cost) - remainderContainers) / freeContainerPrice;

                totalContainers += additionalRoundContainers;
                additionalRoundContainers += remainderContainers;

                while (additionalRoundContainers >= freeContainerPrice)
                {
                    remainderContainers = additionalRoundContainers % freeContainerPrice;
                    additionalRoundContainers = (additionalRoundContainers - remainderContainers) / freeContainerPrice;
                    totalContainers += additionalRoundContainers;
                    additionalRoundContainers += remainderContainers;

                }

                output.Add(totalContainers);
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
