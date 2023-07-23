using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PalindromeCheck();
        }

        static void PalindromeCheck()
        {
            Console.WriteLine("Enter thing for Palindrome check");
            string s = Console.ReadLine();
            string original = s;
            s = s.ToLower();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string rev = new string(arr);
            if (s == rev)
            {
                Console.WriteLine("{0} is Plaindrome", original);
            }
            else
            {
                Console.WriteLine("{0} is not Plaindrome", original);
            }
        }

    }
}
