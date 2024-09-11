using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false; // убрать предаток
            Random rand = new Random();//генерация случ чисел, созд объект класса рандом
            int cursorX = rand.Next(Console.BufferWidth); // возвар случ число типа инт
            int cursorY = rand.Next(Console.BufferHeight); // возвар случ число типа инт
            Console.WriteLine($"X = {cursorX}, Y = {cursorY}");
            Console.SetCursorPosition(cursorX, cursorY);
            char symbol = (char)2;
            Console.WriteLine(symbol);
            ConsoleKey key;
            do
            {
                switch (key)
                {
                    case ConsoleKey.W: cursorY--; break;
                    case ConsoleKey.S: cursorY++; break;
                    case ConsoleKey.A: cursorX -= 2; break;
                    case ConsoleKey.D: cursorX += 2; break;
                }
                if (cursorY < 0) cursorY = 0;
                if (cursorX < 0) cursorX = 0;
                if (cursorY > Console.BufferHeight - 1) cursorY = Console.BufferHeight - 1;
                if (cursorX > Console.BufferWidth - 1) cursorX = Console.BufferWidth - 1;
                Console.Clear();
                Console.SetCursorPosition(cursorX, cursorY);
               
            }
            while
            { 
            }

            //Console.Write("Введите положение консоли по ординате X: ");
            //int cursorX = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите положение консоли по ординате Y: ");
            //int cursorY = Convert.ToInt32(Console.ReadLine());
            //while (true)
            //{
            //    Console.Clear();                                //отчищаем консоль
            //    Console.SetCursorPosition(cursorX, cursorY);      //координты курсора
            //    Console.Write(Convert.ToChar("☺"));            // прорисовка курсора/рожицы
            //    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            //    switch (keyInfo.Key)
            //    {
            //        case ConsoleKey.W:
            //            cursorY--;
            //            break;
            //        case ConsoleKey.S:
            //            cursorY++;
            //            break;
            //        case ConsoleKey.A:
            //            cursorX--;
            //            break;
            //        case ConsoleKey.D:
            //            cursorX++;
            //            break;
            //        case ConsoleKey.Escape:
            //            return;
            //    }
                #region MyRegion
                //ConsoleKey key;
                //do
                //{
                //    key = Console.ReadKey(true).Key;
                //    //Console.WriteLine(key);
                //    //ConsoleKey.
                //    Console.WriteLine(key.ToString());
                //} while (key != ConsoleKey.Escape); 
                #endregion
            }
        }
    }
}
