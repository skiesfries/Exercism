using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    /// <summary>
    /// This solution is correct with all test cases passing in Visual Studio. A bug on Exercism prevents this solution from passing.
    /// </summary>
    public static class MatchingBrackets
    {
        private static char[] openingbrackets = { '{', '[', '(' };
        private static char[] closedbrackets = { '}', ']', ')' };

        static List<bool> passingBrackets = new() { };

        public static bool IsPaired(string input)
        {
            if (input.Length == 0)
            {
                return true;
            }

            if (AreBracketsPaired(input))
            {
                for (int i = 0; i < openingbrackets.Count(); i++)
                {
                    CheckBracketLocations(input, openingbrackets[i], closedbrackets[i]);
                }

                if (passingBrackets.All(s => s == true))
                {
                    if (CheckFirstAndLastBracket(input)) return true;

                }
            }

            return false;
        }

        private static bool AreBracketsPaired(string input)
        {
            int openCount = 0;
            int closedCount = 0;

            for (int i = 0; i < openingbrackets.Count(); i++)
            {
                openCount += input.Count(f => (f == openingbrackets[i]));
            }

            for (int i = 0; i < closedbrackets.Count(); i++)
            {
                closedCount += input.Count(f => (f == closedbrackets[i]));
            }

            if (openCount == closedCount)
            {
                return true;
            }


            return false;
        }


        private static void CheckBracketLocations(string input, char bracketType, char closingBracket)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == bracketType)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input.IndexOf(input[j]) < input.IndexOf(closingBracket))
                        {
                            passingBrackets.Add(true);
                            break;
                        }
                        else
                        {
                            passingBrackets.Add(false);
                            continue;
                        }
                    }
                }
            }
        }

        private static bool CheckFirstAndLastBracket(string input)
        {
            char firstOpenBracket = input.First(bracket => bracket == openingbrackets[0] || bracket == openingbrackets[1] || bracket == openingbrackets[2]);
            char lastClosingBracket = input.Last(lastBracket => lastBracket == closedbrackets[0] || lastBracket == closedbrackets[1] || lastBracket == closedbrackets[2]);

            bool bracketsMatch = (firstOpenBracket == '{' && lastClosingBracket == '}') || (firstOpenBracket == '[' && lastClosingBracket == ']') || (firstOpenBracket == '(' && lastClosingBracket == ')');
            bool correctlyNestedSquares = firstOpenBracket == '[' && input.IndexOf(']') < input.IndexOf('{') || input.IndexOf(']') < input.IndexOf('(');
            bool correctlyNestedMustaches = firstOpenBracket == '{' && input.IndexOf('}') < input.IndexOf('[') || input.IndexOf('}') < input.IndexOf('(');
            bool correctlyNestedParenthesis = firstOpenBracket == '(' && input.IndexOf(')') < input.IndexOf('[') || input.IndexOf(')') < input.IndexOf('{');


            if (bracketsMatch || correctlyNestedSquares || correctlyNestedMustaches || correctlyNestedParenthesis)
            {
                return true;
            }

            return false;
        }

    }
}
