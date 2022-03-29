using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32.Models
{
    class Teacher:Person
    {
        public int Salary;
        public Teacher(string name, string surname, int point)
        {
            Name = name;
            Surname = surname;
            Salary = point;
        }
        public static bool operator >(Teacher teach1, Teacher teach2)
        {
            return teach1.Salary > teach2.Salary;
        }
        public static bool operator <(Teacher teach1, Teacher teach2)
        {
            return teach1.Salary < teach2.Salary;
        }

    }
}
