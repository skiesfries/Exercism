using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class Triangle
    {
        public static bool IsScalene(double side1, double side2, double side3)
        {
            if (CheckForInequality(side1,side2,side3))
            {
                if (side1 != side2 && side2 != side3)
                {
                    return true;
                }
            }
            
            return false;
        }

        public static bool IsIsosceles(double side1, double side2, double side3)
        {
            if (CheckForInequality(side1,side2,side3)) //checks if Triangle is actually a triangle based on triangle inequality rules
            {
                if ((side1 == side2 && side2 == side1) || (side2 == side3 && side3 == side2) || (side1 == side3 && side3 == side1))
                {
                    return true;
                }
                else if (IsEquilateral(side1, side2, side3))
                {
                    return true;
                }
            }
           
            return false;
        }

        public static bool IsEquilateral(double side1, double side2, double side3)
        {
            if (side1 + side2 + side3 != 0)
            {
                if (side1 == side2 && side2 == side3)
                {
                    return true;
                }
            }
           
            return false;
        }

        private static bool CheckForInequality(double a, double b, double c)
        {
            if (a + b >= c && b + c >= a && a + c >= b)
            {
                return true;
            }

            return false;
        }
    }
}
