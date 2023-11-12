using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Home
{
    public class Student : Person
    {
        public int Course { get; set; }
        public void AdvanceCourse()
        {
            Course++;
        }
        public Student(string name, int age, int course) : base(name, age)
        {
            Name = name;
            Age = age;
            Course = course;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ this.GetHashCode();
                return hashCode;
            }
        }
        public static Student RandomStudent()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            string[] names = new string[] { "Бекенова Арайлым Ерланқызы", "Өндіріс Диас Жанатұлы", 
                "Солтанай Аружан Берікқызы", "Қаирбаева Дильназ Амантайқызы", 
                "Болатбек Айгерим", "Арапова Асылжан Тулюгуновна", "Ерғалым Ерсанат" };
            int age = rnd.Next(18, 25);
            int course = rnd.Next(1, 5); 
            return new Student
            (names[rnd2.Next(names.Length*4)* rnd.Next(names.Length * 4) % names.Length],age, course);
        }
        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
            {
                return false;
            }
            Student student = (Student)obj;
            return Course == student.Course;
        }
    }
}
