using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometricalClass
{
    public class Circle : Shape
    {
        private double Radius; //радиус

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area => Math.PI * Radius * Radius;
        public override double Perimeter => 2 * Math.PI * Radius;
    }
}
