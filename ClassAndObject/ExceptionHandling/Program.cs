using System;
namespace ExceptionProgram{
    class ExceptionProgramClass
    {
        static void Main(String[] args)
        {
            int First_Number = 45;
            int Second_Number = 0;
            
            try
            {
                int Result = First_Number / Second_Number;
                Console.WriteLine(Result);
            }
            catch(DivideByZeroException Ref)
            {
                Console.WriteLine(Ref.Message);
                
            }
            Console.ReadLine();
        }
    } 
}