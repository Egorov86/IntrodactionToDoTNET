using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для вычисления факториала: ");
            int fact_input = int.Parse(Console.ReadLine());
            int i, factorial;
            for (i = 1, factorial=1; i <= fact_input; i++)
            {
                factorial = factorial * i;
            }
            Console.Write("Факториал равен: "); Console.WriteLine(factorial ) ;
        }
    }
}
