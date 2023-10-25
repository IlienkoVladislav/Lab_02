using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                int nextIndex = (i + 1) % points.Length;
                double sideLength = Math.Sqrt(Math.Pow(points[nextIndex].X - points[i].X, 2) +
                                              Math.Pow(points[nextIndex].Y - points[i].Y, 2));
                perimeter += sideLength;
            }

            Console.WriteLine($"Багатокутник має периметр {perimeter}");
        }
    }
}