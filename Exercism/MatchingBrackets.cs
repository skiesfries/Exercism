using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class MatchingBrackets
    {
        private static char[] openingbrackets = { '{', '[', '(' };
        private static char[] closedbrackets = {'}',']',')' };

        public static bool IsPaired(string input)
        {
            if (AreSquareBracketsPaired(input))
            {
                return true;
            }

            return false;
        }

        private static bool AreSquareBracketsPaired(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '[')
                {
                   
                }
            }
            return false;
        }
    }
}
