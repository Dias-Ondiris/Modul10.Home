using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Home
{
    public class Teacher : Person
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public override string ToString()
        {
            return base.ToString() + $", Студенты: {Students.Count}";
        }
        public Teacher(string name, int age) : base(name, age)
        {
        }
        public override bool Equals(object obj)
        {
            var teacher = obj as Teacher;
            return teacher != null &&
                   base.Equals(obj) &&
                   Students.SequenceEqual(teacher.Students);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = base.GetHashCode();
                foreach (var student in Students)
                {
                    hashCode = (hashCode * 397) ^ student.GetHashCode();
                }
                return hashCode;
            }
        }
        public static Teacher RandomTeacher()
        {
            Random rnd = new Random();
            string[] names = new string[] { "Герцен Е.А", "Қасенхан А.М", "Бейсембекова Р.Н.", "Алибиева Ж.М", "Бейсембекова Р.Н." };
            int age = rnd.Next(25, 65); 
            Teacher randomTeacher = new Teacher
            ( names[rnd.Next(names.Length)], age);
            return randomTeacher;
        }
    }
}
