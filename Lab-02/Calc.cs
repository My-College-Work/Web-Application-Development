using System;

namespace Clac {
    public class Program {
        public static int Add(int op1, int op2) {
            return op1 + op2;
        }
        public static int Sub(int op1, int op2) {
            return op1 - op2;
        }
        public static int Mul(int op1, int op2) {
            return op1 * op2;
        }
        public static double Div(int op1, int op2) {
            if(op2 == 0) {
                Console.WriteLine("!!!!!!");
                return 0;
            }
            return op1 / op2;
        }
    }
}