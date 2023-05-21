using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDayWithSwith
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number Between 1-7");
            int N_Day = int.Parse(Console.ReadLine());
            switch (N_Day)
            {
                case 1:
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Toaday is Monday");
                  

                    break;
                case 2:
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Toaday is Tuesday");
                    break;
                case 3:
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Toaday is Wednesday");
                    break;
                case 4:
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Toaday is Thursaday");
                    break;
                case 5:
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Toaday is Friday");
                    break;
                case 6:
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Toaday is Saturady");
                    break;
                case 7:
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Toaday is Sunday");
                    break;
                default:
                    Console.WriteLine("Enter Number between 1-7");
                    break;
            }
            Console.ReadLine();
        }
    }
}
