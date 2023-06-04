using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic.Arthimatic_Program
{
    internal class SwapingTwoNumber
    {
       
        public static void Swaping()
        {
            bool flag; int number1;int number2;
            do
            {
                Console.WriteLine("Enter your First Number");
                flag = int.TryParse(Console.ReadLine(), out number1);
                Console.WriteLine("Enter Your Second Number");
                flag = int.TryParse(Console.ReadLine(), out number2);
                if (flag)
                {
                    number1 = number1 + number2;  //30+20=50
                    number2 = number1 - number2; // 50 - 20=30
                    number1 = number1 - number2; //50 - 30=20
                    Console.WriteLine(number1 + " =>  " + number2);
                }
                else
                {
                    Console.WriteLine("your enter format is not correct");
                }
            } while (!flag);
        }
    }
}
