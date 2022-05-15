using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class BeerSong
    {
        public static string Recite(int startBottles, int takeDown)
        {
            int originalStartBottles = startBottles;
            string beersOnTheWall = "";
            for (int i = 0; i < takeDown; i++)
            {
                if (startBottles == 1)
                {
                    beersOnTheWall += $"{startBottles} bottle of beer on the wall, {startBottles} bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n";
                    beersOnTheWall += $"No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, {originalStartBottles} bottles of beer on the wall.\n";
                }
                else if (startBottles - 1 == 1)
                {
                    beersOnTheWall += $"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\nTake one down and pass it around, {startBottles - 1} bottle of beer on the wall.\n";
                }
                else if (originalStartBottles == 0)
                {
                    beersOnTheWall += $"No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, {originalStartBottles} bottles of beer on the wall.\n";
                }
                else
                {
                    beersOnTheWall += $"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\nTake one down and pass it around, {startBottles - 1} bottles of beer on the wall.\n";
                }
                startBottles--;
            }
            
            return beersOnTheWall;

        }
    }
}
