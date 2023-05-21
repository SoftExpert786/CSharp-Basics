using System;
namespace ArrayProgram
{
    class ArrAyInPut
    {
        static void Main(String[] args)
        {
        Again:
            Console.WriteLine("Enter the Length Of Your Array");
            int LengthOFArray = int.Parse(Console.ReadLine());
            string[] ArrayOfName = new string[LengthOFArray];
            for (int number = 0; number < LengthOFArray; number++)
            {
                Console.WriteLine("Enter Your Name");
                ArrayOfName[number] = Console.ReadLine();

            }
            Console.WriteLine("--------List of Your Name Following-------");
            foreach (string name in ArrayOfName)
            {
                Console.WriteLine(name);
            }
           
            Console.WriteLine("If You Want Again Add Data in Array Write Yes");
            string AgainInter = Console.ReadLine();

            if (AgainInter == "Yes")
            {
                goto Again;
            }
            else
            {
                Console.ReadLine();
            }
        }
    }
}