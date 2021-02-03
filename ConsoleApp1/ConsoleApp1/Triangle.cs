using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangle
    {

        public float findArea(float a, float b, float c)
        {
            validateDimentions(a, b, c);
            validateTriangle(a, b, c);
            
            float s = (a + b + c) / 2;
            return (float)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        private void validateDimentions(float a,float b, float c)
        {
            if(a<0 || b<0 || c < 0)
            {
                throw new Exception("Dimention must be positive values, Not a valid triangle!");
            }
        }

        private void validateTriangle(float a,float b, float c)
        {
            if ((a + b <= c) || a + c <= b || b + c <= a)
            {
                throw new Exception("Not a valid triangle!");
            }

        }
    }
}
