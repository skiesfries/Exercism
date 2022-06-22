using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class Etl
    {
        public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
        {
            Dictionary<string, int> newScores = new();

            foreach (var kvp in old)
            {
                for (int i = 0; i < kvp.Value.Length; i++)
                {
                    newScores.Add(kvp.Value[i].ToLower(), kvp.Key);
                }
               
            }
            var orderedNewScores = newScores.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            return orderedNewScores;
        }
    }
}
