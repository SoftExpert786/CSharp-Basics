using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic.ArrayProgram
{
    internal class MaxAndMin
    {
        public static void checkvalue()
        {
            try
            {
                int[] numberArray; int arrlength; bool flag;
                do
                {
                    Console.WriteLine("Enter your array laength");
                    flag = int.TryParse(Console.ReadLine(), out arrlength);
                    numberArray = new int[arrlength];
                    Console.WriteLine("enter your list ELEMENT");
                    for (int i = 0; i < arrlength; i++)
                    {
                        flag = int.TryParse(Console.ReadLine(), out numberArray[i]);
                    }
                    foreach (int i in numberArray)
                    {
                        Console.WriteLine(i);
                    }
                    for (int i = 0; i < arrlength; i++)
                    {
                        if (numberArray[0] < numberArray[i])
                        {
                            numberArray[0] = numberArray[i];
                        }
                    }
                    Console.WriteLine(numberArray[0]);
                    {

                    }
                
                } while (flag);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    } }
