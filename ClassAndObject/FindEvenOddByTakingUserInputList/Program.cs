using System;
namespace EvenProgram
{
    class main
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Range of Your List");
            int ListRange = int.Parse(Console.ReadLine());
            int[] NumberList=new int[ListRange];
            Console.WriteLine("Enter Your Number For List");
            for (int i = 0; i < ListRange; i++)  
            {
                NumberList[i] = int.Parse((Console.ReadLine()));    

            }
            foreach (int number in NumberList)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("This number \"{0}\" is Even ",number);
                }
                else
                {
                    Console.WriteLine("This number \"{0}\" is Odd ", number);
                }
                
            }
            Console.ReadLine();
        }
    }
}