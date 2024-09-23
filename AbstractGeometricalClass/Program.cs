using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometricalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("КРУГ: ");
            Circle circle = new Circle(5);
            Console.WriteLine("Площадь: " + circle.Area);
            Console.WriteLine("Периметр: " + circle.Perimeter);

            Console.WriteLine("ТРЕУГОЛЬНИК: ");
            Triangle triangle = new Triangle(5, 2.4, 6);
            Console.WriteLine("Площадь: " + triangle.Area);
            Console.WriteLine("Периметр: " + triangle.Perimeter);

            Console.WriteLine("КВАДРАТ: ");
            Square square = new Square(8);
            Console.WriteLine("Площадь: " + square.Area);
            Console.WriteLine("Периметр: " + square.Perimeter);

            Console.WriteLine("ПРЯМОУГОЛЬНИК: ");
            Rectangle rectangle = new Rectangle(3, 5);
            Console.WriteLine("Площадь: " + rectangle.Area);
            Console.WriteLine("Периметр: " + rectangle.Perimeter);
        }
    }
}
