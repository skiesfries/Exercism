using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> multiples, int max)
        {
            var products = new List<int>();
            foreach (var multiple in multiples)
            {
                if (multiple > 0)
                {
                    for (int i = 1; i * multiple < max; i++)
                    {
                        products.Add(i * multiple);
                    }
                }
            }
            return products.Distinct().Sum();
        }
    }
}
