using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp_No = 1;
            Console.WriteLine("Enter the Number To Find Factorial Value");
            int Fo_N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Fo_N; i++)
            {
                temp_No = temp_No * i;

            }
            Console.WriteLine("Factorial Value of {0} is {1}", Fo_N, temp_No);
            Console.ReadLine();
        }
    }
}
