using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static readonly string delimiter1 = "\n-------------------------------\n";
        static void Main(string[] args)
        {
            int n = 5;
            int h = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i <= n; i++)
            {
                for (int j = i; j < h; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++) Console.Write(" ");
                for (int j = i; j < n; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++) Console.Write(" ");
                for (int j = 0; j <= i; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++) Console.Write(" "); Console.Write("/");
                for (int j = 0; j < 2 * i; j++) Console.Write(" "); Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++) Console.Write(" "); Console.Write("\\");
                for (int j = 0; j < (n - 1 - i) * 2; j++) Console.Write(" "); Console.Write("/");
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write(i % 2 == j % 2 ? "+ " : "- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 && j == 0) Console.Write ((char)218);
                    else if (i == 0 && j == n) Console.Write ((char)191);
                    else if (i == n && j == 0) Console.Write ((char)192);
                    else if (i == n && j == n) Console.Write ((char)217);
                    else if (i == 0 || i == n) Console.Write ((char)196);
                    else if (j == 0 || j == n) Console.Write ((char)179);
                    else if (i % 2 == j % 2) Console.Write ((char)219);
                    else Console.Write ((char)254);
                }
                Console.WriteLine();
            }
        }
    }
}
