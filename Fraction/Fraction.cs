#define HHHHHHH
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        public int Integer { get; set; } //автосвойства, котог=рые не требуют объявления 
        //переменной поскольку сами не явно её объявляют
        public int Numerator { get; set; }
        ///  /////////////////////
        int denominator;
        // Обычные свойства которые применяются к переменной  'denominator':
        public int Denominator
        {
            get => denominator;
            set => denominator = value == 0 ? 1 : value;
        }
        ///  /////////////////////

        //                Constructors:
        public Fraction()
        {
            Console.WriteLine($"DefConstructor:\t{GetHashCode()}");
        }
        public Fraction(int integer)
        {
            this.Integer = integer;
            Console.WriteLine($"1ArgConstructor:{GetHashCode()}");
        }
        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            Console.WriteLine($"Constructor:{GetHashCode()}");
        }
        ~Fraction()
        {
            Console.WriteLine($"Destructor:\t{GetHashCode()}");
        }

        //                 Methods:
        public void Print()
        {
            if (Integer != 0) Console.Write(Integer);
            if (Numerator != 0)
            {
                Console.Write("(");
                Console.Write($"{Numerator}/{Denominator}");
                Console.Write(")");
            }
            else if (Integer == 0) Console.Write(0);
            Console.WriteLine();
        }
    }
}
