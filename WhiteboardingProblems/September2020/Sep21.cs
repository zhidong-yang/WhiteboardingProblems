using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep21
    {
        /*
         * A string is considered to be in title case if each word in the string is either (a) capitalised (that is, only the first 
         * letter of the word is in upper case) or (b) considered to be an exception and put entirely into lower case unless it is the 
         * first word, which is always capitalised.

            Write a function that will convert a string into title case, given an optional list of exceptions (minor words). The list of minor 
            words will be given as a string with each word separated by a space. Your function should ignore the case of the minor words string 
            -- it should behave in the same way even if the case of the minor word string is changed.

            ###Arguments (Haskell)

            First argument: space-delimited list of minor words that must always be lowercase except for the first word in the string.
            Second argument: the original string to be converted.
            ###Arguments (Other languages)

            First argument (required): the original string to be converted.
            Second argument (optional): space-delimited list of minor words that must always be lowercase except for the first word in the string. 
            The JavaScript/CoffeeScript tests will pass undefined when this argument is unused.
            ###Example

            Kata.TitleCase("a clash of KINGS", "a an the of")   => "A Clash of Kings"
            Kata.TitleCase("THE WIND IN THE WILLOWS", "The In") => "The Wind in the Willows"
            Kata.TitleCase("the quick brown fox")               => "The Quick Brown Fox"
         */

        public static string TitleCase(string title, string minorWords = "")
        {
            // if the title is empty, return empty string
            if (String.IsNullOrEmpty(title))
            {
                return "";
            }

            // if the optional minorWords is not an empty string, change them into a string array for reference
            // make sure each word in the string array is in lower case
            string[] minorWordsArray;
            if (!String.IsNullOrEmpty(minorWords))
            {
                minorWordsArray = minorWords.Split(' ');
                for (int i = 0; i < minorWordsArray.Length; i++)
                {
                    minorWordsArray[i] = minorWordsArray[i].ToLower();
                } 
            }
            else
            {
                minorWordsArray = new string[0];
            }

            // make the title into a string array
            string[] titleArray = title.Split(' ');
            for (int i = 0; i < titleArray.Length; i++)
            {
                titleArray[i] = titleArray[i].ToLower();
            }
            // the first word in the title is always capitalized
            char[] firstWordArray = titleArray[0].ToCharArray();
            firstWordArray[0] = Char.ToUpper(firstWordArray[0]);            
            titleArray[0] = new string(firstWordArray);

            // starting from the second word in the title: if minorWords does not contain the word, capitalize it
            if (titleArray.Length > 1)
            {
                for (int i = 1; i < titleArray.Length; i++)
                {
                    if (!minorWordsArray.Contains(titleArray[i]))
                    {
                        char[] wordArray = titleArray[i].ToCharArray();
                        wordArray[0] = Char.ToUpper(wordArray[0]);
                        titleArray[i] = new string(wordArray);
                    }
                }
            }

            StringBuilder result = new StringBuilder();
            foreach (var item in titleArray)
            {
                result.Append(item);
                result.Append(" ");
            }
            result.Remove(result.Length - 1, 1);

            string output = result.ToString();
            return output;
        }
    }
}
