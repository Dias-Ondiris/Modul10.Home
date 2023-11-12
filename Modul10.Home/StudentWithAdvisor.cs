using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Home
{
    public class StudentWithAdvisor : Student
    {
        public Teacher Advisor { get; set; }
        public StudentWithAdvisor(string name, int age, int course) : base( name,  age ,course) { }
        public StudentWithAdvisor(string name, int age, int course, Teacher advisor)
            : base(name, age, course)
        {
            Advisor = advisor;
        }
        public override string ToString()
        {
            return base.ToString() + $", Куратор: {(Advisor != null ? Advisor.Name : "Нет")}";
        }
        public override bool Equals(object obj)
        {
            var studentWithAdvisor = obj as StudentWithAdvisor;
            return studentWithAdvisor != null &&
                   base.Equals(obj) &&
                   EqualityComparer<Teacher>.Default.Equals(Advisor, studentWithAdvisor.Advisor);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode()*Advisor.GetHashCode();
        }
    }
}
