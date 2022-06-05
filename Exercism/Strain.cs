using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    static class Strain
    {
        public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            IEnumerable<T> result = collection.Where(c => predicate(c));
            return result;
        }

        public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            IEnumerable<T> result = collection.Where(c => !predicate(c));
            return result;
        }
    }
}
