using Newtonsoft.Json;
using System;
using System.IO;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("Orxan","Taliov",24);
            Employee employee2 = new Employee("Qabil","Hesenov",19);
            Employee employee3 = new Employee("Hesen","Ismetov",45);
            Employee employee4 = new Employee("Kamil","Aliyev",36);
           
            Department department = new Department();
            department.employees.Add(employee1);
            department.employees.Add(employee2);
            department.employees.Add(employee3);
            department.employees.Add(employee4);

            string jsonStr = JsonConvert.SerializeObject(department.employees);
            
            using (StreamWriter sr=new StreamWriter(@"C:\Users\tu7b9ed4n\source\repos\ConsoleApp14\ConsoleApp14\json1.json"))
            {
                sr.WriteLine(jsonStr);
            }
            string empstr;
            using (StreamReader sr = new StreamReader(@"c:\users\tu7b9ed4n\source\repos\consoleapp14\consoleapp14\json1.json"))
            {
                empstr = sr.ReadToEnd();
            }
            var dep = JsonConvert.DeserializeObject(empstr);
            Console.WriteLine(dep);

        }
    }
}
