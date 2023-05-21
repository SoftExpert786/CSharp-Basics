using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number Which table you want to Print");
            int table = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int resultt = i * table;
                Console.WriteLine("{0} * {1} = {2}", table, i, resultt);

            }

            Console.ReadLine();
        }
    }
}
