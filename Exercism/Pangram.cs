using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class Pangram
    {
        public static List<char> Letters = new() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
       
        public static bool IsPangram(string input)
        {
            string lowercaseInput = input.ToLower();
            List<char> lettersInInput = new() { };
            for (int i = 0; i < input.Length; i++)
            {
                if (Letters.Contains(lowercaseInput[i]) && !lettersInInput.Contains(lowercaseInput[i]))
                {
                    lettersInInput.Add(lowercaseInput[i]);
                }
                if (lettersInInput.Count == Letters.Count)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
