using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>() 
            { 
                new Employee() {Id=101, Name="AAM"},
                new Employee() {Id=102, Name="JHB"},
                new Employee() {Id=103, Name="PRD"},
            };

            int count = list.Count(x => x.Name.StartsWith("A"));
            Console.WriteLine(count);

            List<int> intList = new List<int> { 1,2,3,4,5,6 };
            List<int> evenList = intList.FindAll(x => (x > 2 && (x%2) == 0));

            foreach (int x in evenList)
            {
                Console.WriteLine(x);
            };
        }
    }
}
