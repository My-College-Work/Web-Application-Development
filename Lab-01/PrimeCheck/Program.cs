using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeCheck();
        }

        static void PrimeCheck()
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int i = 2;
            for (; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("It's not a prime");
                    break;
                }
            }
            if (i >= Math.Sqrt(num))
            {
                Console.WriteLine("It's a prime");
            }
        }

    }
}
