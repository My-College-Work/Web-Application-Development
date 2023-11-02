using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyDelegate
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Experience { get; set; }

        public static void PromoteEmp(List<Employee> elist)
        {
            foreach (Employee emp in elist)
            {
                if (emp.Experience > 5)
                {
                    Console.WriteLine("Name: {0} is promoted. \n", emp.Name);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>
            {
                new Employee() { Id = 101, Name = "Ananya", Salary = 70, Experience = 7 },
                new Employee() { Id = 102, Name = "Nirva", Salary = 70, Experience = 8 },
                new Employee() { Id = 103, Name = "Parita", Salary = 50, Experience = 4 },
            };
            Employee.PromoteEmp(list);
        }
    }
}
