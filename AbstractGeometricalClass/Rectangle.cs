using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometricalClass
{
    public class Rectangle : Shape
    {
        private double Length; //длинна
        private double Width;  //ширина

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area => Length * Width;
        public override double Perimeter => 2 * (Length + Width);
    }
}
