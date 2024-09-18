using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public Fraction(int integer, int numerator, int denominator)
        {
            this.Integer = integer;
            this.Numerator = numerator;
            this.Denominator = denominator;
            Console.WriteLine($"Constructor:\t{GetHashCode()}");
        }
        public Fraction(Fraction other)
        {
            this.Integer = other.Integer;
            this.Numerator = other.Numerator;
            this.Denominator = other.Denominator;
            Console.WriteLine($"CopyConstructor:{GetHashCode()}");
        }
        ~Fraction()
        {
            Console.WriteLine($"Destructor:\t{GetHashCode()}");
        }
        //                  OPERATOR
        public static Fraction operator *(Fraction l, Fraction r)
        {
            /*Fraction left = l.Improper();
            Fraction right = r.Improper();
            Fraction res = new Fraction
                (
                left.Numerator * right.Numerator,
                left.Denominator * right.Denominator
                );
            return res;*/
            return new Fraction
            (
            l.Improper().Numerator * r.Improper().Numerator,
            l.Improper().Denominator * r.Improper().Denominator
            ).Reduce().Proper();
        }
        public static Fraction operator /(Fraction l, Fraction r)
        {
            return l * r.Inverted();
            /*Fraction left = l.Improper();
            Fraction right = r.Improper();
            Fraction res = new Fraction
                (
                left.Numerator * right.Denominator,
                left.Denominator * right.Numerator
                );
            return res;*/
        }
        public static Fraction operator +(Fraction l, Fraction r)
        {
            Fraction left = l.Improper();
            Fraction right = r.Improper();
            Fraction res = new Fraction
                (
                left.Numerator * right.Denominator + right.Numerator * left.Denominator,
                left.Denominator * right.Denominator
                );
            return res;
            /* return new Fraction(l.Integer + r.Integer, l.Numerator + r.Numerator, l.Denominator + r.Denominator);*/
        }
        public static Fraction operator -(Fraction l, Fraction r)
        {
            Fraction left = l.Improper();
            Fraction right = r.Improper();
            Fraction res = new Fraction
                (
                left.Numerator * right.Denominator - right.Numerator * left.Denominator,
                left.Denominator * right.Denominator
                );
            return res;
        }
        public static Fraction operator ++(Fraction l) //префиксный инкремент
        {
            /*
            return new Fraction(l.Integer + 1, l.Numerator + 1, l.Denominator + 1);
            */
            l.Improper();
            l++;
            return l;
        }
        public static Fraction operator --(Fraction l) //префиксный декремент
        {
            return new Fraction(l.Integer - 1, l.Numerator - 1, l.Denominator - 1);
        }
        /*public static Fraction operator += (Fraction l, Fraction r)
        {
            l.Integer += r.Integer;
            l.Numerator += r.Numerator;
            l.Denominator += r.Denominator;
            return l;
            /*return new Fraction(l.Integer = l.Integer + r.Integer,
            l.Numerator = l.Numerator + r.Numerator,
            l.Denominator = l.Denominator + r.Denominator);*//*
        }
        public static Fraction operator -= (Fraction l, Fraction r)
        {
            l.Integer -= r.Integer;
            l.Numerator -= r.Numerator;
            l.Denominator -= r.Denominator;
            /*return new Fraction(l.Integer = l.Integer - r.Integer,
            l.Numerator = l.Numerator - r.Numerator,
            l.Denominator = l.Denominator - r.Denominator);
        }*/
        /*public static bool operator ==(Fraction l, Fraction r)
        {
            return l.Integer == r.Integer && l.Numerator == r.Numerator && l.Denominator == r.Denominator;
        }*/
        public static bool operator ==(Fraction l, Fraction r) // оператор равно
        {
            return l.Integer == r.Integer && l.Numerator == r.Numerator && l.Denominator == r.Denominator;
        }
        public static bool operator !=(Fraction l, Fraction r) // оператор неравно
        {
            return !(l == r);
        }
        //             Comparison operators:
        public static bool operator >(Fraction left, Fraction right)
        {
            return 
            left.Improper().Numerator*right.Improper().Denominator >
            right.Improper().Numerator*left.Improper().Denominator;
        }
        public static bool operator <(Fraction left, Fraction right)
        {
            return
            left.Improper().Numerator * right.Improper().Denominator <
            right.Improper().Numerator * left.Improper().Denominator;
        }


        //                 Methods:
        Fraction Proper()
        {
            Fraction copy = new Fraction(this);
            copy.Integer += copy.Numerator / copy.Denominator;
            copy.Numerator %= copy.Denominator;
            return copy;
        }
        Fraction Improper()
        {
            Fraction copy = new Fraction(this);
            copy.Numerator += copy.Integer * copy.Denominator;
            copy.Integer = 0;
            return copy;
        }
        public Fraction Inverted()
        {
            Fraction inverted = new Fraction(this).Improper();
            (inverted.Numerator, inverted.Denominator) = (inverted.Denominator, inverted.Numerator);
            return inverted;
        }
        public Fraction Reduce()
        {
            int more, less, rest;
            if (Numerator > Denominator)
            {
                more = Numerator;
                less = Denominator;
            }
            else
            {
                less = Numerator;
                more = Denominator;
            }
            do
            {
                rest = more % less;
                more = less;
                less = rest;
            } while (rest > 0);
            int GCD = more;   // Greatest common divisor = наиб общ делитель
            Denominator = more;
            Numerator = more;
            return this;
        }
        public void Print()
        {
            if (Integer != 0) Console.Write(Integer);
            if (Numerator != 0)
            {
                if(Integer !=0)Console.Write("(");
                Console.Write($"{Numerator}/{Denominator}");
                if (Integer != 0) Console.Write(")");
            }
            else if (Integer == 0) Console.Write(0);
            Console.WriteLine();
        }
        public override string ToString()
        {
            //return base.ToString();
            string print = "";
            if (Integer != 0) print += Integer;
            if (Numerator != 0)
            {
                if (Integer !=0) print += "(";
                print += $"{Numerator}/{Denominator}";
                if (Integer != 0) print += ")";
            }
            else if (Integer == 0) print += (0);
            return print;

        }
    }
}
