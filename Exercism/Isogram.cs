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
            List<char> letters = new() { };
            for (int i = 0; i < word.Length; i++)
            {
                if (letters.Contains(word[i]))
                {
                    return false;
                }
                else
                    letters.Add(word[i]);
            }
            return false;
        }
    }
}
