using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
    public class Student : Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
    }
        public Student(string lastName, string firstName, uint age,
        string speciality, string group, double rating, double attendance
        ) : base(lastName, firstName, age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }
    public Student(Human human, string speciality, string group, double rating, double attendance) : base(human)
    {
        
    }
    ~Student()
    {
        Console.WriteLine($"Destructor:\t{GetHashCode()}");
    }
    public override string Tostring()
    {
        return base.ToString() + $"{S}";
    }
}
