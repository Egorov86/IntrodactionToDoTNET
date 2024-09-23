using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometricalClass
{
    public class Triangle : Shape
    {
        private double Side1; //сторона - 1
        private double Side2; //сторона - 2
        private double Side3; //сторона - 3

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double Area
        {
            get
            {
                // формула Герона
                double s = (Side1 + Side2 + Side3) / 2;
                return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
            }
        }

        public override double Perimeter => Side1 + Side2 + Side3;
    }
}
