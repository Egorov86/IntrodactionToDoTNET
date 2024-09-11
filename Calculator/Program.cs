using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");
            string expresion = Console.ReadLine();
            Console.Write(expresion + " = ");
            String[] tokens = expresion.Split('+', '-', '*', '/');
            //for (int i = 0; i < tokens.Length; i++)
            //{
            //    Console.Write(tokens[i] + "\t");
            //}
            Console.WriteLine();
            double a = Convert.ToDouble(tokens[0]);
            double b = Convert.ToDouble(tokens[1]);
            //метод Contains() класса 'string' 
            if (expresion.Contains('+')) Console.WriteLine(a + b);
            else if (expresion.Contains('-')) Console.WriteLine(a - b);
            else if (expresion.Contains('*')) Console.WriteLine(a * b);
            else if (expresion.Contains('/')) Console.WriteLine(a / b);
            else Console.WriteLine("No operation");
        }
    }
}
