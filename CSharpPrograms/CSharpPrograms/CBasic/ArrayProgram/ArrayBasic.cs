using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic.ArrayProgram
{
    internal class ArrayBasic
    {
        public static void ArrayFun()
        {
            int[] ArrayNo = { 1, 2, 3 };
            string[] ArrayName = new string[3];
            ArrayName[0] = "Zain";
            ArrayName[1] = "Ali";
            ArrayName[2] = "Adnan";

            for (int index = 0; index < ArrayName.Length; index++)
            {
                try
                {
                    Console.WriteLine(ArrayNo[index]);
                    Console.WriteLine(ArrayName[index]);

                }
                catch (Exception refe)
                {
                    Console.WriteLine(refe.Message);
                }



            }
            Console.ReadLine();
        }
        public static void ArrayInput()
        {
            Console.WriteLine("Enter the Length of List");
            int arrayLength = int.Parse(Console.ReadLine());
            string[] arrayName = new string[arrayLength];
            Console.WriteLine("Enter Student Name");
            for (int index = 0; index < arrayName.Length; index++)
            {
                arrayName[index] = Console.ReadLine();


            }
            Console.WriteLine("------Name of Student Are---------");
            foreach (string StName in arrayName)
            {
               
                Console.WriteLine(StName);
            }
        }
    }
}