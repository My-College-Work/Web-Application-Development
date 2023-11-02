using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate void HelloDelegate(string str);
        public delegate int MathOp(int a, int b);

        static void Main(string[] args)
        {
            HelloDelegate h = new HelloDelegate(print);
            MathOp op1 = new MathOp(Add);
            MathOp op2 = new MathOp(Sub);
            h("Are you enjoying?\n");
            h.Invoke("Really!!!");
            Console.Write("\nAddition: {0}", op1(2,3));
            Console.Write("\nSubtraction: {0}\n", op2(2,3));

        }
        public static void print(string message)
        {
            Console.WriteLine(message);
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b) 
        {  
            return a - b; 
        }
    }
}
