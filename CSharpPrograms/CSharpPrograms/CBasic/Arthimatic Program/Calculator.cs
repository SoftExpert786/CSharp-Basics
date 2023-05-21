using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic.Arthimatic_Program
{
    internal class Calculator
    {
       public static void CalCulatorFun()
        {
            Console.WriteLine("Enter the First Number");
            decimal F_Number=decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Operator +,-,*,/");
            string Operator= Console.ReadLine();

            Console.WriteLine("Enter the Second Number");
            decimal S_Number = decimal.Parse(Console.ReadLine());

            if (Operator == "+")
            {
                decimal Result = F_Number + S_Number;
                Console.WriteLine("{0} + {1} = {2}",F_Number,S_Number,Result);
            }
            if (Operator == "*")
            {
                decimal Result = F_Number * S_Number;
                Console.WriteLine("{0} * {1} = {2}", F_Number, S_Number, Result);
            }
            if (Operator == "-")
            {
                decimal Result = F_Number - S_Number;
                Console.WriteLine("{0} - {1} = {2}", F_Number, S_Number, Result);
            }
            if (Operator == "/")
            {
                try
                {
                    decimal Result = F_Number / S_Number;
                    Console.WriteLine("{0} / {1} = {2}", F_Number, S_Number, Result);
                }
                catch(Exception refV)
                {
                    Console.WriteLine(refV.Message);    
                }
            }

        }
    }
}
