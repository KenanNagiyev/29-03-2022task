using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32.Models
{
    abstract class Person
    {
        private static int _id = 0;
        public int Id { get; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            ++_id;
            Id = _id;
        }
        public string ShowInfo()
        {
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}, Age: {Age}";
        }
    }
}
