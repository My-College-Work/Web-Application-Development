using System;
using Sum;

namespace ConsoleApplication1 {
    class Application {
        static void Main(string[] args) {
            int a = 5;
            int b = 10;
            int r = Addition.Add(a,b);
            Console.WriteLine($"The sum of {a} + {b} is: {r}");
            Console.ReadLine();
        }
    }
}