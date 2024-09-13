using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    internal class Point
    {
        /*double x, y;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                //if(value...)...
                x = value; // value - открыть доступ
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }*/
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x = 0, double y = 10)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Constructor:\t{this.GetHashCode()}");
        }
        ~Point()
        {
            Console.WriteLine($"Destructor\t{this.GetHashCode()}");
        }

              //   Methods:
        public void Print()
        {
            Console.WriteLine($"X={X}, Y={Y}");
            //Console.WriteLine($"X={x}, Y={y}");
        }
    }
}
