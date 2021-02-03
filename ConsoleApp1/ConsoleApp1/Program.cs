using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle();
                printResult(triangle.findArea(3, 4, 5));
                printResult(triangle.findArea(7, 5, 10));
                printResult(triangle.findArea(10, 6, 8));
                printResult(triangle.findArea(10, -6, 8));
                printResult(triangle.findArea(-10, 400, 50));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }

        static void printResult(float output)
        {
            Console.WriteLine("The area for this triangle is:\n" + output);
        }
    }
}
