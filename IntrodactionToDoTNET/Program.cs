using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrodactionToDoTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Introduction to .NET";
            //Console.Write("Hello.NET");
            Console.WriteLine("Hello.NET");
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            
            //Console.CursorLeft = 24;
            //Console.CursorTop = 5;
            Console.SetCursorPosition(16, 5);
            Console.WriteLine("Вот так задаются координаты");
            Console.ResetColor();

            //Задали размеры окна
            //Console.WindowWidth = 44;
            //Console.WindowHeight = 16;
            Console.SetWindowSize(64, 16);

            //Задаем положение окна на экране:
            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;

            //Console.SetWindowPosition(10, 10);

            //Задаем размер буфера консоли:
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;

            
        }
    }
}
