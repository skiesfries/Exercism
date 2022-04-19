using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public class Leap
    {
        
        
        
        public static bool IsLeapYear(int year)
        {
            bool divisibleByFour = year % 4 == 0;
            bool divisbleByBy100 = year % 100 == 0;
            bool divisbleByBy400 = year % 400 == 0;

            bool meetsRequirements = divisibleByFour && !divisbleByBy100 || (divisbleByBy100 && divisbleByBy400);
            return meetsRequirements;
        }
    }
}
