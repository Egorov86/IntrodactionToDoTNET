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

            try
            {
                Console.Write("Введите число для вычисления факториала: ");
                int n = Convert.ToInt32(Console.ReadLine());
                double f = 1;
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                    Console.WriteLine($"{i}! = {f}"); //интерполяция строк
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
