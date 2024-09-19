//#define INHERITANCE_1
#define INHERITANCE_2
using Academy_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_1
{
    class Program
    {
        static void Main(string[] args)
        {
#if INHERITANCE_1
			Human human = new Human("Vercetty", "Tommy", 30);
			Console.WriteLine(human);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			Console.WriteLine(student);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			Console.WriteLine(teacher); 
#endif

#if INHERITANCE_2
            Human tommy = new Human("Vercetty", "Tommy", 30);
            Console.WriteLine(tommy);

            Student student_tommy = new Student(tommy, "Theft", "Vice", 95, 98);
            Console.WriteLine(student_tommy);

            Human ricardo = new Human("Diaz", "Ricardo", 50);
            Console.WriteLine(ricardo);

            Teacher teacher_ricardo = new Teacher(ricardo, "Weapons distribution", 20);
            Console.WriteLine(teacher_ricardo);

            Human gaz = new Human("Gaz", "Fring", 40);
            Console.WriteLine(gaz);

            Student student_gaz = new Student(gaz, "Theft", "Vice", 95, 98);
            Console.WriteLine(student_gaz);

            Graduate graduate = new Graduate(student_gaz, "Red", 2020);
            Console.WriteLine(graduate); 
#endif
            Human[] group = new Human[]
            {
                new Student(tommy, "Theft", "Vice", 90, 80),
                new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20),
                new Graduate(student_gaz, "Blue", 2020)
            };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(group[i]);
            }
        }
    }

}
