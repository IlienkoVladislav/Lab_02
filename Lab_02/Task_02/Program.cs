using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 1, "B");
            Point C = new Point(1, 0, "C");

            Figure triangle = new Figure(A, B, C);
            triangle.CalculatePerimeter();

            Point D = new Point(1, 1, "D");
            Figure quadrilateral = new Figure(A, B, C, D);
            quadrilateral.CalculatePerimeter();

            Console.ReadLine();
        }
    }
}
