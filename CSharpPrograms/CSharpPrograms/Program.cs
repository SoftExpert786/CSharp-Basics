using CSharpPrograms.CBasic.ArrayProgram;
using CSharpPrograms.CBasic.Arthimatic_Program;
using CSharpPrograms.OOPProgram.EncapSulation;
using CSharpPrograms.OOPProgram.Interfce;
using CSharpPrograms.OOPProgram.Inheritance;
using System.Runtime.CompilerServices;

namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {
            Stat:
            Console.WriteLine("IF you Want to Find Array Write 1" + 
                "IF you Want to Find Using Input Method Array Write 2" +
                "IF you Want to Find Even Number Write 3" +
                "If You Want to Find Factorical Value of a number  Write 4" +
                "IF you Want to Print table Write 5" +
                "IF you Want to Calculate Write 6" +
                "If you want to Print Grade Of Student Write 7 " +
                "IF you Want to Deposit are Withdraw amount Write 8" +
                "IF you Want to Find area of Ishape Write 9" +
                "IF you Want to Find Area Shape Write 10"
                );
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                ArrayBasic.ArrayFun();
            }
            else if (select == 2)
            {
                ArrayBasic.ArrayInput();
            }
            else if (select == 3) { EvenOdd.Even(); }
            else if (select == 4)
            {
                FactorialValue.Factorial();
            }
            else if (select == 5)
            {
                Table.TableFun();
            }
            else if (select == 6)
            {
                Calculator.CalCulatorFun();
            }
            else if (select == 7)
            {
                Grade.GradeFun();
            }
            else if (select == 8)
            {
                Bank bank = new Bank();
            Again:
                Console.WriteLine("Enter your Account Number");
                int Accountnumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Amount ");
                decimal AccountBalance = decimal.Parse(Console.ReadLine());
                Console.WriteLine("To Check Balance Enter 1,To Deposit Amount 2,To Wiyhdraw Amount 3");
                int selecti = int.Parse(Console.ReadLine());
                if (selecti == 1)
                {
                    BankAccount.CheckBalance(bank);


                }
                else if (selecti == 2)
                {
                    BankAccount.DepositBalance(Accountnumber, AccountBalance);

                }
                else if (selecti == 3)
                {
                    BankAccount.WithdrawBalance(Accountnumber, AccountBalance);
                }
                else
                {
                    Console.WriteLine("You have enter Wrong number");
                }
                goto Again;
            }
            else if (select == 9)
            {
                shape shapeI = new shape();

                shapeI.GetDemonsional(10, 56);
                shapeI.Area();
                shapeI.Perimeter();

                Console.ReadLine();
            }
            else if (select == 10)
            {
                Circle shape = new Circle();
                shape.GetDemonsion(4.5);
                shape.Area();
                shape.Perimeter();
                Rectanguler shape1 = new Rectanguler();
                shape1.GetDemonsion(4.5, 4.6);
                shape1.Area();
                shape1.Perimeter();
                Square shape2 = new Square();
                shape2.GetDemonsion(4.5);
                shape2.Area();
                shape2.Perimeter();
            }
            else
            {
                Console.WriteLine("You enter Wrong Number Write Correct number between 1-10");
            }
            goto Stat;

        }
    }
}