using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter your number");
            int Number = int.Parse(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine("{0}  is Even Even", Number);
                goto start;
            }
            else Console.WriteLine("{0}  is odd Number", Number);
            goto start;

        }
    }
}
