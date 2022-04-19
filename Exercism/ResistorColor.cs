using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercism
{
    public static class ResistorColor
    {
       enum ResistorColors
        {
            Black,
            Brown,
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Violet,
            Grey,
            White
                    }
        public static int ColorCode(string color)
        {
            if (Enum.TryParse<ResistorColors>(color, out ResistorColors code))
            {
                return (int)code;
            }
            else
                WriteLine("That color was not found");
            return 404;
        }

        public static string[] Colors()
        {
            string[] colors = Enum.GetNames(typeof(ResistorColors));
            return colors;
        }
    }
}
