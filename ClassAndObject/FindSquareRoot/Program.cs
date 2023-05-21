using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findsquareornot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int F_No = 6;
            int F_No2 = 36;
            int tem = F_No * F_No;
            if (tem == F_No2)
            {
                Console.WriteLine("Second number is Square of First Number");
            }
            else Console.WriteLine("Second number is Not Square of First Number");

            Console.WriteLine("Enter your First Number");
            int F_N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Second Number");
            int S_N = int.Parse(Console.ReadLine());
            int temin = F_N * F_N;
            if (temin == F_N)
            {
                Console.WriteLine("Second number is Square of First Number");
            }
            else Console.WriteLine("Second number is Not Square of First Number");
            Console.Read();
        }
    }
}
