using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcutorUsingMethod
{
    internal class Program
    {

        static void Main(string[] args) {




           

            Stop:
                Console.WriteLine("Enter your First Number");
                long F_N = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your operator +,-,*,/,square");
                string Op = Console.ReadLine();
                Console.WriteLine("Enter your Second Number");
                long S_N = int.Parse(Console.ReadLine());


                if (Op == "+")
                {
                    Console.WriteLine("= {0}", F_N + S_N);

                    goto Stop;
                }
                if (Op == "-")
                {
                    Console.WriteLine("= {0}", F_N - S_N);

                    goto Stop;
                }
                if (Op == "*")
                {
                    long mul = F_N * S_N;
                    Console.WriteLine("={0}", mul);

                    goto Stop;
                }
                if (Op == "/")
                {
                    Console.WriteLine("= {0}", F_N / S_N);

                    goto Stop;
                }
                if (Op == "square")
                {
                    Console.WriteLine("={0}", F_N * F_N);

                    goto Stop;
                }
                else
                {
                    Console.WriteLine("Wrong Operator");
                }
            }
        }
    }








    