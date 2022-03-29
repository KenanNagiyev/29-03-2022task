using System;
using ConsoleApp32.Models;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Kenan", "Nagiyev", 20, 80);
            Student stud2 = new Student("Murad", "Niftullayev", 20, 70);
            Console.WriteLine(stud1 > stud2);
            Console.WriteLine(stud1.ShowInfo());
            Console.WriteLine(stud2.ShowInfo());
            Teacher teach1 = new Teacher("Ibrahim", "Huseynov", 1500);
            Teacher teach2 = new Teacher("Perviz", "Hesenov", 500);
            Console.WriteLine(teach1 > teach2);
            Student student1 = new Student("Kenan", "Nagiyev", 20, 80);
            Student student2 = new Student("Murad", "Niftullayev", 20, 70);
            Student student3 = new Student("Ibrahim", "Huseynov", 20, 75);
            Student student4 = new Student("Revan", "Huseynov", 20, 65);
            GroupMate gm = new GroupMate(5);
            gm.students[0] = student1;
            gm.students[1] = student2;
            gm.students[2] = student3;
            gm.students[3] = student4;
            Console.WriteLine(gm.students[0].Point);
            Console.WriteLine(gm.students[1].Point);
            Console.WriteLine(gm.students[2].Point);
            Console.WriteLine(gm.students[3].Point);
        }
    }
}
