﻿using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Exercism
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(DifferenceOfSquares.CalculateSquareOfSumLINQ(10));
            WriteLine(DifferenceOfSquares.CalculateSumOfSquaresLINQ(10));
            WriteLine(DifferenceOfSquares.CalculateDifferenceOfSquares(10));
        }
    }
}
