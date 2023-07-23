using System;
using Sub;
using Sum;
namespace ConsoleApplication3 {
    class Application {
        static void Main(string[] args) {
            Console.WriteLine("Enter Two Vales");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator from +, -");
            string op = Console.ReadLine();
            switch(op) {
                case "+":
                    Console.WriteLine(Addition.Add(a,b));
                    break;
                case "-":
                    Console.WriteLine(Subtract.Minus(a,b));
                    break;
                default:
                    break;
            }
        }
    }
}