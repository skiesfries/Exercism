using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    class Gigasecond
    {
        //return a datetime after a gigasecond has passed from the given moment 
        public static DateTime Add(DateTime moment) => moment.AddSeconds(1e9);
        
    }
}
