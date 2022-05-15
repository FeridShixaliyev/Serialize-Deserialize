using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Department
    {
        public Department()
        {
            Id = _id++;
        }
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public List<Employee>employees = new List<Employee>();
    }
}
