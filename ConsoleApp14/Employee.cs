using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Employee
    {
        public Employee(string name,string surname,int age)
        {
            Id = _id++;
            Name = name;
            Surname = surname;
            Age = age;
        }
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
