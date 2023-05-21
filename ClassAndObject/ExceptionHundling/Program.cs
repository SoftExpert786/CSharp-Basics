using System;
namespace ExceptionProgram
{
    class Calculator
    {
        public void Divde(int FirstNumber,int SecondNumber ) {
            try
            {
                int Result = FirstNumber / SecondNumber;
                Console.WriteLine(Result);
            }
            catch(DivideByZeroException Ref) {
              
              Console.WriteLine(Ref.Message);
            }
        
        }
    }
    class main
    {
        static void Main(String[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Enter your First Number");
            int F_Number=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Second Number");
            int S_Number = int.Parse(Console.ReadLine());
            calculator.Divde(F_Number, S_Number);
            Console.ReadLine();
        }
    }
}