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
        public double Distance(Point other) // метод Distance
        {
            double dx = this.X - other.X;
            double dy = this.Y - other.Y;
            return Math.Round(Math.Sqrt(dx * dx + dy * dy), 3); //Math.Round округление после запятой на 3 знкака
        }
        public static double Static_Distance(Point a, Point b) // статический метод Distance
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;
            return Math.Round(Math.Sqrt(dx * dx + dy * dy), 3);
        }
        public void Print()
        {
            Console.WriteLine($"X={X}, Y={Y}");
            //Console.WriteLine($"X={x}, Y={y}");
        }
    }
}
