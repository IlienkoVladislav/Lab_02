﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__01
{
    internal class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double CalculateArea() => side1 * side2;
        public double CalculatePerimeter() => 2 * (side1 + side2);

        public double Area => CalculateArea();
        public double Perimeter => CalculatePerimeter();
    }
}
