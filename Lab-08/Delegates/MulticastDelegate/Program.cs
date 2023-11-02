using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate int MathOp(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            MathOp d1 = new MathOp(p.Add);
            MathOp d2 = null;

            d2 = p.Sub;
            Console.WriteLine(d1(10, 5));
            Console.WriteLine(d2.Invoke(10, 5));

            MathOp d3 = d1 + d2;
            Console.WriteLine(d3(12, 2));
            foreach(MathOp i  in d3.GetInvocationList())
            {
                int res = i(12,2);
                Console.WriteLine("In loop " + res);
            }
            MathOp d4 = d3 - d1;
            Console.WriteLine(d4(14, 1));
            foreach (MathOp i in d4.GetInvocationList())
            {
                int res = i(14, 1);
                Console.WriteLine("In loop " + res);
            }
            Console.ReadLine();
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
