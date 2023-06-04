using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.OOPProgram
{

    public delegate void MyCalculator(double Num1, double num2);
    class calculator
    {
        public static void Add(double num1, double num2)
        {
            double Result = num1 + num2;
            Console.WriteLine("{0} + {1} ={2}", num1, num2, Result);
        }
        public static void divide(double num1, double num2)
        {
            double Result = num1 + num2;
            Console.WriteLine("{0} + {1} ={2}", num1, num2, Result);
        }
        public static void Mul(double num1, double num2)
        {
            double Result = num1 * num2;
            Console.WriteLine("{0} * {1} ={2}", num1, num2, Result);
        }
        public static void Sub(double num1, double num2)
        {
            double Result = num1 - num2;
            Console.WriteLine("{0} - {1} ={2}", num1, num2, Result);
        }


    }
}
