using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class BinarySearch
    {
        public static int Find(int[] input, int value)
        {
            
            int start = 0;
            int end = input.Length - 1;


            while (start <= end)
            {
                int middle = Math.Abs((start+end)/ 2);

                if (value == input[middle])
                {
                    return Array.IndexOf(input, value);
                    
                }
                else if (value <= middle)
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
            }

            return -1;
        }
    }
}
