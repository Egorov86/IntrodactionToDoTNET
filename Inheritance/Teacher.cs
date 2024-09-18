using Academy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher
    {
        public class Teacher : Human
        {
            public string Speciality { get; set; }
            public string Group { get; set; }
            public double Rating { get; set; }
            public uint Experience { get; set; }
            public Teacher(Human human, string speciality)
        }
    }
}
