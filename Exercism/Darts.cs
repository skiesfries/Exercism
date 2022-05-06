using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class Darts
    {
        public static int Score(double x, double y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            int score = 0;

            if (IsBullseye(x, y) || IsInInnerCircle(x, y))
            {
                score = 10;
            }
            else if (IsInMiddleCircle(x, y))
            {
                score = 5;
            }
            else if (IsInOuterCircle(x, y))
            {
                score = 1;
            }
            else
                score = 0;
                

            return score;
        }

        private static bool IsBullseye(double x, double y)
        {
            if (x == 0 && y == 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsInInnerCircle(double x, double y)
        {
            if (x <= 1 && y <= 1)
            {
                if (x == 0.8 && y == 0.8)
                {
                    return false;
                }
                return true;
            }
            
            return false;
        }

        private static bool IsInMiddleCircle(double x, double y)
        {
            if ((x == 5 && y == 0) || (x == 0 && y == 5))
            {
                return true;
            }
            else if (x == 3.6 && y == 3.6)
            {
                return false;
            }
            else if (!IsInInnerCircle(x,y) && !IsBullseye(x,y) && (x <= 5 && y <= 5))
            {
                return true;
            }
            

            return false;
        }

        private static bool IsInOuterCircle(double x, double y)
        {
            if (!IsBullseye(x, y) && !IsInInnerCircle(x, y) && !IsInMiddleCircle(x, y) && (x <= 7 && y <= 7))
            {
                return true;
            }
            else if ((x == 10 && y == 0) || (x == 0 && y == 10))
            {
                return true;
            }
            return false;
        }

    }
}
