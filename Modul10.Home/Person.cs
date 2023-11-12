using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Home
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"ФИО: {Name}, Возраст: {Age}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Person person = (Person)obj;
            return (Name == person.Name) && (Age == person.Age);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode()*Age.GetHashCode();
        }
        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator ==(Person left, Person right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }
            return left.Equals(right);
        }
        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}
