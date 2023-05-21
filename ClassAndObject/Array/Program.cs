using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Array Range");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;

                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();

        }

    }
}
