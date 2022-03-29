using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32.Models
{
    class Student:Person
    {
        public int Point;
        public Student(string name, string surname, int age, int point)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;

        }

        public static bool operator >(Student stud1, Student stud2)
        {
            return stud1.Point > stud2.Point;
        }
        public static bool operator <(Student stud1, Student stud2)
        {
            return stud1.Point < stud2.Point;
        }

    }
}
