using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            string lowercaseWord = word.ToLower();
            List<char> letters = new() { };
            List<char> charsAllowed = new() {' ', '-'};
            for (int i = 0; i < lowercaseWord.Length; i++)
            {
                if (letters.Contains(lowercaseWord[i]))
                {
                    if (charsAllowed.Contains(lowercaseWord[i]))
                    {
                        continue;
                    }
                    return false;
                }
                else
                    letters.Add(lowercaseWord[i]);
            }
            return true;
        }
    }
}
