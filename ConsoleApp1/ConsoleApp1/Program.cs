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
                printResult(triangle.getArea(3,4,5));
               
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
