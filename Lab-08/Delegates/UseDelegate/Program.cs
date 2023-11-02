using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDelegate
{
    delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Experience { get; set; }

        public static void PromoteEmp(List<Employee> elist, IsPromotable isEligible)
        {
            foreach (Employee emp in elist)
            {
                if (isEligible(emp))
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

            // Program p = new Program();
            // IsPromotable promotable = new IsPromotable(p.Promote);
            // Employee.PromoteEmp(list, promotable);
            Employee.PromoteEmp(list, emp => emp.Name.StartsWith("P"));
        }
        public bool Promote(Employee emp)
        {
            if(emp.Experience < 5)
            {
                return true;
            }
            return false;
        }

    }
}
