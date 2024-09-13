using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack - статическая память
            //Heap - динамическая память
            /*Point A = new Point(); //оператор 'new' вызывает конструктор класса.
            A.SetX(2);
            A.SetY(3);
            Console.WriteLine($"X={A.GetX()}, Y={A.GetY()}");
            A.Print();*/

            Point B = new Point(); //Default constructor
            B.X = 7;
            B.Y = 8;
            B.Print();

            Point C = new Point(11, 12);

            //Console.SetWindowSize(200, 120);
        }
    }
}
