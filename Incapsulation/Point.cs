using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    class Point
    {
        /*double x;
		double y;
		public double X
		{
			get
			{
				return x;
			}
			set
			{
				//if(value...)......
				x = value;	//value - открывает доступ к переданному значению
			}
		}
		public double Y
		{
			get { return y; }
			set { y = value; }
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
			this.x = x;	//В языке C# отсутствуют указатели, а следовательно отсутсвует оператор '->'
		}
		public void SetY(double y)
		{
			this.y = y;
		}*/

        public double X { get; set; }   //Автосвойства для 'X'
        public double Y { get; set; }   //Автоствойства для 'Y'

        //			  Constructors:
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Constructor:\t{this.GetHashCode()}");
        }
        public Point(Point other)
        {
            this.X = other.X;
            this.Y = other.Y;
            Console.WriteLine($"CopyConstructor:{this.GetHashCode()}");
        }
        ~Point()
        {
            Console.WriteLine($"Destructor:\t{this.GetHashCode()}");
        }

        //				Operators:
        public static Point operator +(Point left, Point right)
        {
            Point res = new Point();
            res.X = left.X + right.X;
            res.Y = left.Y + right.Y;
            return res;
        }
        public static Point operator ++(Point obj)
        {
            obj.X++;
            obj.Y++;
            return obj;
        }
        public static bool operator ==(Point left, Point right)
        {
            return left.X == right.X && left.Y == right.Y;
        }
        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }

        //   Methods:

        // ДОМАШНЯЯ РАБОТА

        /*public double Distance(Point other) // метод Distance
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
        }*/
        public void Print()
        {
            Console.WriteLine($"X={X}, Y={Y}");
            //Console.WriteLine($"X={x}, Y={y}");
        }
    }
}
