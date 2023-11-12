using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = Teacher.RandomTeacher();
            Teacher teacher2 = Teacher.RandomTeacher();
            Student student1 = Student.RandomStudent();
            Student student2 = Student.RandomStudent();
            Student student3 = Student.RandomStudent();
            Student student4 = Student.RandomStudent();

            teacher1.Students.Add(student1);
            teacher1.Students.Add(student2);
            teacher1.Students.Add(student3);
            teacher2.Students.Add(student3);

            Console.WriteLine(teacher1);
            Console.WriteLine(teacher2);
            foreach (var student in teacher1.Students)
            {
                Console.WriteLine(student);
            }
            foreach (var student in teacher1.Students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey( );
        }
    }
}
