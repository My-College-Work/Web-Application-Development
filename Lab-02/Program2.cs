using System;
using Clac;
namespace ConsoleApplication2 {
    class Application {
        static void Main(string[] args) {
            Console.WriteLine("Enter Two Vales");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator from +, -, *, /");
            string op = Console.ReadLine();
            switch(op) {
                case "+":
                    Console.WriteLine(Program.Add(a,b));
                    break;
                case "-":
                    Console.WriteLine(Program.Sub(a,b));
                    break;
                case "*":
                    Console.WriteLine(Program.Mul(a,b));
                    break;
                case "/":
                    Console.WriteLine(Program.Div(a,b));
                    break;
                default:
                    break;
            }
        }
    }
}