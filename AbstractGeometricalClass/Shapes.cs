using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometricalClass
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
    }
}
