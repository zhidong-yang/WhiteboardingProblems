﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep11
    {
        /*
        In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list 
        with the strings filtered out.

        Example
        ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
        ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
        ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}
         */

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> output = new List<int>();
            foreach (var item in listOfItems)
            {
                if (item.GetType().ToString() != "System.String")
                {
                    output.Add((int)item);
                }
            }

            return output;
        }
    }
}
