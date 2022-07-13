using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    /* CHALLENGE: Create an implementation of the rotational cipher, also sometimes called the Caesar cipher.
         * The Caesar cipher is a simple shift cipher that relies on transposing 
         * all the letters in the alphabet using an integer key between 0 and 26.
         * Using a key of 0 or 26 will always yield the same output due to modular arithmetic. 
         * The letter is shifted for as many values as the value of the key.
         * Latin alphabet: abcdefghijklmnopqrstuvwxyz
        */
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    char letter = char.ToLower(text[i]);
                    char rotatedChar = Convert.ToChar(letter + shiftKey);

                    if (rotatedChar > 'z')
                    {
                        text = text.Remove(i, 1).Insert(i, GetRotatedCharWithWrappedAlphabet(letter, shiftKey, text[i])); 
                    }
                    else
                    {
                        rotatedChar = CheckIfShouldBeUpper(text[i], rotatedChar);
                        text = text.Remove(i, 1).Insert(i, rotatedChar.ToString());
                    }
                }
            }
            return text;
        }

        private static string GetRotatedCharWithWrappedAlphabet(char letter, int shiftKey, char textChar)
        {
            int newShiftKey = (letter + shiftKey) - 'z';
            char rotatedCharWrapped = Convert.ToChar('a' + newShiftKey - 1);

            rotatedCharWrapped = CheckIfShouldBeUpper(textChar, rotatedCharWrapped);
            return rotatedCharWrapped.ToString();
        }

        private static char CheckIfShouldBeUpper(char textChar, char charToBeUpper)
        {
            if (char.IsUpper(textChar))
            {
                charToBeUpper = char.ToUpper(charToBeUpper);
            }
            return charToBeUpper;
        }
    }
}
