using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardingProblems.September2020
{
    public class Sep14
    {
        /*
         * For building the encrypted string:
            Take every 2nd char from the string, then the other chars, that are not every 2nd char, and concat them as new String.
            Do this n times!

            Examples:

            "This is a test!", 1 -> "hsi  etTi sats!"
            "This is a test!", 2 -> "hsi  etTi sats!" -> "s eT ashi tist!"
            Write two methods:

            string Encrypt(string text, int n)
            string Decrypt(string encryptedText, int n)
            For both methods:
            If the input-string is null or empty return exactly this value!
            If n is <= 0 then return the input text.
         */

        public static string Encrypt(string text, int n)
        {
            if (String.IsNullOrEmpty(text) || n <= 0)
            {
                return text;
            }

            StringBuilder firstPart = new StringBuilder();
            StringBuilder secondPart = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                // starting from i = 0, every second char is at an odd-numbered index
                if (i % 2 != 0)
                {
                    firstPart.Append(text[i]);
                }
                else
                {
                    secondPart.Append(text[i]);
                }
            }

            firstPart.Append(secondPart);
            string intermediaryString = firstPart.ToString();

            return Encrypt(intermediaryString, n - 1);
        }

        public static string Decrypt(string encryptedText, int n)
        {
            if (String.IsNullOrEmpty(encryptedText) || n <= 0)
            {
                return encryptedText;
            }

            char[] outputCharArray = new char[encryptedText.Length];
            // whether encryptedText has even or odd number of chars, the decrypted string's first char
            // is located at encryptedText's index position of encryptedText.Length/2
            for (int i = 1; i < outputCharArray.Length; i += 2)
            {
                outputCharArray[i] = encryptedText[i / 2];
            }
            for (int i = 0; i < outputCharArray.Length; i += 2)
            {
                outputCharArray[i] = encryptedText[i + (encryptedText.Length - i) / 2];
            }

            string output = new string(outputCharArray);

            return Decrypt(output, n - 1);

        }
    }
}
