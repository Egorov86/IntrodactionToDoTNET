using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_1
{
    internal class Graduate : Human
    {
        public string Color_Diplom { get; set; }
        public double Year_Of_Release { get; set; }
        public Graduate
            (
            string color_diplom, double year_of_release, string lastName, string firstName, uint age,
            string speciality, string group, double rating, double attendance
            ) : base(lastName, firstName, age)
        {
            Color_Diplom = color_diplom;
            Year_Of_Release = year_of_release;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }
        public Graduate(Student student, string speciality, string group, double rating, double attendance) : base(student)
        {
            Color_Diplom = Color_Diplom;
            Year_Of_Release = Year_Of_Release;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }
        ~Graduate()
        {
            Console.WriteLine($"SDestructor:\t{GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Color_Diplom} {Year_Of_Release}";
        }
    }
   
}
