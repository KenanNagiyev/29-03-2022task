using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32.Models
{
    class GroupMate
    {
        public Student[] students;

        public GroupMate(int n)
        {
            students = new Student[n];
        }
        public Student this[int index]
        {
            get
            {
                if (index < students.Length)
                {
                    return students[index];
                }
                throw new Exception();
            }
            set
            {
                if (index < students.Length)
                {
                    students[index] = value;
                }
                throw new Exception();
            }
        }
    }
}
