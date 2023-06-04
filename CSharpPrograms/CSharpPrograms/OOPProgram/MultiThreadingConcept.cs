using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpPrograms.OOPProgram
{
    internal class MultiThreadingConcept
    { 
        public static void func1()
        {
            for (int i = 1; i < 30; i++)
            {
                Console.WriteLine("func1 = " + i );
            }
        }
        public static void func2()
        {
            for (int i = 1; i < 30; i++)
            {
                if (i == 20)
                {
                    Thread.Sleep(5000);
                }
                Console.WriteLine("func2 = " + i);
            }
        }
        public static void func3()
        {
            for (int i = 1; i < 30; i++)
            {
                Console.WriteLine("func3 = " + i);
            }
        }
    }
}
