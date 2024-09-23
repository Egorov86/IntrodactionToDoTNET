using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometricalClass
{
    public class Square : Shape
    {
        private double side_Length; // длинна боковой стороны

        public Square(double sideLength)
        {
            side_Length = sideLength;
        }

        public override double Area => side_Length * side_Length;
        public override double Perimeter => 4 * side_Length;
    }
}
