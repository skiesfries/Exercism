using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class ResistorColorDuo
    {
        private enum ResistorColors
        {
            black, brown, red, orange, yellow, green, blue, violet, grey, white
        }

        public static int Value(string[] colors)
        {
            string firstColor = colors[0];
            string secondColor = colors[1];

            ResistorColors matchingColor1 = (ResistorColors)Enum.Parse(typeof(ResistorColors), firstColor);
            ResistorColors matchingColor2 = (ResistorColors)Enum.Parse(typeof(ResistorColors), secondColor);

            int value1 = (int)matchingColor1;
            int value2 = (int)matchingColor2;

            int finalValue = int.Parse(value1.ToString() + value2.ToString());

            return finalValue;
        }
    }
}
