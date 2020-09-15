using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep15
    {
        /*
         * Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.

            Rules for a smiling face:

            Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
            A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
            Every smiling face must have a smiling mouth that should be marked with either ) or D
            No additional characters are allowed except for those mentioned.

            Valid smiley face examples: :) :D ;-D :~)
            Invalid smiley faces: ;( :> :} :]

            Example
            countSmileys([':)', ';(', ';}', ':-D']);       // should return 2;
            countSmileys([';D', ':-(', ':-)', ';~)']);     // should return 3;
            countSmileys([';]', ':[', ';*', ':$', ';-D']); // should return 1;
            
            Note
            In case of an empty array return 0. You will not be tested with invalid input (input will always be an array). Order of the 
            face (eyes, nose, mouth) elements will always be the same
         */

        public static int CountSmileys(string[] smileys)
        {
            if (smileys.Length == 0)
            {
                return 0;
            }

            char[] smilyElements = { ':', ';', ')', 'D' };
            int output = 0;
            foreach (var item in smileys)
            {
                if (item.Length >= 2) //every smiley face has to have at least eyes and mouth
                {
                    if ((item[0] == smilyElements[0] || item[0] == smilyElements[1]) && 
                        (item[item.Length-1] == smilyElements[2] || item[item.Length-1] == smilyElements[3]))
                    {
                        output++;
                    }
                }
            }

            return output;
        }
    }
}
