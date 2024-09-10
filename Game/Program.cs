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
            Console.Write("Введите положение консоли по ординате X: ");
            int cursorX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите положение консоли по ординате Y: ");
            int cursorY = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.Clear();                                //отчищаем консоль
                Console.SetCursorPosition(cursorX, cursorY);      //координты курсора
                Console.Write(Convert.ToChar("☺"));            // прорисовка курсора/рожицы
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        cursorY--;
                        break;
                    case ConsoleKey.S:
                        cursorY++;
                        break;
                    case ConsoleKey.A:
                        cursorX--;
                        break;
                    case ConsoleKey.D:
                        cursorX++;
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
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
