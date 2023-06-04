using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic.Arthimatic_Program
{
    internal class Calculator
    {

        public static void CalCulatorFun()
        {
            try {
                decimal F_Number; decimal S_Number; bool Flag;
                do
                {

                    Console.WriteLine("Enter the First Number");
                    Flag = decimal.TryParse(Console.ReadLine(), out F_Number);

                    Console.WriteLine("Enter The Operator +,-,*,/");
                    string Operator = Console.ReadLine();

                    Console.WriteLine("Enter the Second Number");
                    Flag = decimal.TryParse(Console.ReadLine(), out S_Number);

                    if (Operator == "+")
                    {
                        decimal Result = F_Number + S_Number;
                        Console.WriteLine("{0} + {1} = {2}", F_Number, S_Number, Result);
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

                        decimal Result = F_Number / S_Number;
                        Console.WriteLine("{0} / {1} = {2}", F_Number, S_Number, Result);
                    }


                } while (!Flag);

            }  catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
    }
    } 
