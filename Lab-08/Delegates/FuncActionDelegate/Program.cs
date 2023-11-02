using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> Display1 = Print;
            Display1("Hello");

            
            Action<int> Display3 = delegate (int i)
            {
                Console.WriteLine(i);
            };
            Display3(121);

            Action<int> Display4 = i => Console.WriteLine(i);
            Display4(-1);
            

            
            Func<int, int, int> add = Sum;
            Console.WriteLine("Sum is: {0}", add(10,23));

            Func<int, int, int> add1 = delegate (int x, int y)
            {
                return x + y;
            };

            Console.WriteLine("Add1 is: {0}", add1(10,23));

            Func<int,int,int>plus = (x,y) => x+y;
            Console.WriteLine("Addition is: " + plus.Invoke(2, 3));

            Console.ReadLine();
            
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
