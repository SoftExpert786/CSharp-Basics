using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic.ArrayProgram
{
    internal class ArrayPrograms
    {
        public static void CountduplicateChar()
        {

            Console.WriteLine("enter the Length of char array");
            int number = Convert.ToInt32(Console.ReadLine());
            char[] charArr = new char[number];
            char[] charArr1 = new char[number];
            char[] charArr2= new char[number];  
            Console.WriteLine("enter {0} char in the Array", number);
            //insert element in the array
            for (int i = 0; i < number; i++)
            {
                charArr[i] = Convert.ToChar(Console.ReadLine());

            }
            //copy element of array to another array
            for (int i = 0; i < charArr.Length; i++)
            {
                charArr1[i] = charArr[i];
            }
            int count = 1;
            //check duplicate char in array
           

            for (int i = 0; i <charArr.Length; i++)
            {
                for (int j = 0; j < charArr.Length; j++)
                {
                    if (charArr[i] == charArr[j])
                    {
                        count++;
                    }
                }
                
            }
            Console.WriteLine(count);
        }
    }
}