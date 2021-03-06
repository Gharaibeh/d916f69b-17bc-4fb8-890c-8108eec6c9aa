﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangle
    {
        /// <summary>
        /// Find the Triangle area
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public float findArea(float side1, float side2, float side3)
        {
            validateDimentions(side1, side2, side3);
            validateTriangle(side1, side2, side3);

            float total = (side1 + side2 + side3) / 2;
            float result =  (float)Math.Sqrt(total * (total - side1) * (total - side2) * (total - side3));
            return (float)Math.Round(result, 2);
        }

        /// <summary>
        /// Validate of one is negative
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        private void validateDimentions(float a, float b, float c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Dimention must be positive values, Not a valid triangle!");
            }
        }

        /// <summary>
        /// Validate if Triangle can be formed
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        private void validateTriangle(float a, float b, float c)
        {
            if ((a + b <= c) || a + c <= b || b + c <= a)
            {
                throw new Exception("Not a valid triangle!");
            }

        }
    }
}
