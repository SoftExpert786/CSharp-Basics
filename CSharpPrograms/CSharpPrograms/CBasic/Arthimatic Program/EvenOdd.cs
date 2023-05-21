using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic.Arthimatic_Program
{
    internal class EvenOdd
    {
        public static void Even()
        {
            try
            {
                bool flag; decimal Number;
                do
                {
                    Console.WriteLine("Enter the number ");
                    flag = decimal.TryParse(Console.ReadLine(), out Number);
                    if (flag)
                    {
                        if (Number % 2 == 0)
                        {
                            Console.WriteLine("Given Number {0} is Even", Number);
                        }
                        else
                        {
                            Console.WriteLine("Given Number {0} is Odd", Number);
                        }
                    }
                } while (!flag);
               

                Console.WriteLine("-----------Separate Even or Odd from List-----------");
                Console.WriteLine("Enter the Length of List");
                int ArrayLength = int.Parse(Console.ReadLine());
                int[] ArrayNo = new int[ArrayLength];
                Console.WriteLine("Enter Your number");
                for (int index = 0; index < ArrayNo.Length; index++)
                {
                    ArrayNo[index] = int.Parse(Console.ReadLine());
                }
                foreach (int index in ArrayNo)
                {
                    if (index % 2 == 0)
                    {
                        Console.WriteLine("Given Number {0} is Even", Number);
                    }
                    else
                    {
                        Console.WriteLine("Given Number {0} is Odd", index);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}


