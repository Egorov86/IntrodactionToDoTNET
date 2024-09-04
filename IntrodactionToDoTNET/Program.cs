#define OUTPUT_TO_SCREEN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrodactionToDoTNET
{
    class Program
    {
        static void Main(string[] args)
        {
#if OUTPUT_TO_SCREEN
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
            // позволяет свернуть часть кода
            //#region CodeSnippet  
            //Задали размеры окна
            //Console.WindowWidth = 44;
            //Console.WindowHeight = 16; 
            //#endregion
            Console.SetWindowSize(64, 16);

            //Задаем положение окна на экране:
            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;

            //Console.SetWindowPosition(10, 10);

            //Задаем размер буфера консоли:
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
#endif

            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine();
            Console.WriteLine(first_name);

            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();
            //Console.WriteLine(last_name);

            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            /*---------------------------------
             Класс 'Сonvert' представляет собой набор статических методов для преобразования типов.
             Этот класс используется как правило в том случае, когда  другие  преобразования не работают.
             ---------------------------------
            */
            //Console.WriteLine(age);
            //операции над строками
            Console.WriteLine(last_name + " " + first_name + " " + age + "years"); //Конкатенация строк
            //Кроме конкатенации строка С# поддерживает форматирование строк:
            Console.WriteLine(String.Format("{0} {1} {2} years", last_name, first_name, age));

            //Самая удобная операция - интерполяция строк
            Console.WriteLine($"{last_name} {first_name} {age} years");
            // Интерполяция это изменение искажения
        }
    }
}
