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
            Point A = new Point(); //оператор 'new' вызывает конструктор класса.
            A.SetX(2);
            A.SetY(3);
            Console.WriteLine($"X={A.GetX()}, Y={A.GetY()}");
            A.Print();
        }
    }
}
