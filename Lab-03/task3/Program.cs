using System;
using Clac;
namespace Kite {
    public class Runner {
        public static void Main() {
            int r = Sub.Substraction(10,7);
            int s = Add.Addition(7,10);
            Console.WriteLine($"{r}\n{s}");
            Console.ReadLine();
        }
    }
}