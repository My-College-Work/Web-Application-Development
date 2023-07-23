using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rajat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCalc();
        }

        static void SimpleCalc()
        {
            Console.WriteLine("Select and enter number as per the operation to be performed");
            Console.WriteLine("Press 1 for SUM");
            Console.WriteLine("Press 2 for SUB");
            Console.WriteLine("Press 3 for MUL");
            Console.WriteLine("Press 4 for DIV");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Operand");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Operand");
            int val2 = int.Parse(Console.ReadLine());
            Console.Write("Your Ans is: ");
            switch (op)
            {
                case 1: Console.WriteLine(val1 + val2); break;
                case 2: Console.WriteLine(val1 - val2); break;
                case 3: Console.WriteLine(val1 * val2); break;
                case 4: Console.WriteLine(val1 / val2); break;
                default: Console.WriteLine("Not valid Operator"); break;
            }

        }
    }
}
