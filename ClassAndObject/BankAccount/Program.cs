using System;
namespace BankAccount
{

    class Bank
    {

        private long AccountBalance = 1000;
        private long Amount;

        public long bal
        {
            get { return AccountBalance; }
            set { AccountBalance = value; }
        }
        public void CheckBalance( Bank bank)
        {


            Console.WriteLine("Your Remaing Account \"{0}\" is", bank.AccountBalance);
        }
    }
    class DepsitFunction
    {
        private long AccountNumber = 12345678;

        public void DepositAnount(Bank bank, long _AccountNumber, long Amount)
        {
            if (this.AccountNumber == _AccountNumber)
            {
                bank.bal = bank.bal + Amount;
                Console.WriteLine(bank.bal);

            }
            else
            {
                Console.WriteLine("Your Account Number is Invalid.Please try again ");
            }

            Console.ReadLine();

        }
        public void WithDrawAmount(Bank bank, long _AccountNumber, long WithDRawAmout)
        {
            if (this.AccountNumber == _AccountNumber)
            {
                if (WithDRawAmout < bank.bal)
                {
                    Console.WriteLine("You have insufident Balance in your Accounr");
                }
                else
                {

                    long amount = 0;
                    amount = bank.bal - WithDRawAmout;
                    Console.WriteLine(amount);


                }
            }
            else
            {
                Console.WriteLine("Your Account Number is Invalid.Please try again ");
            }

        }
    }

    class main
    {

        static void Main(String[] args)
        {
            Bank bank = new Bank();
        Again:
            Console.WriteLine("Enter Your Account Number xxxxxxxx");

            long AccountNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("If You Want To Check Balance Write check");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                bank.CheckBalance(bank);
            }
            DepsitFunction depsitFunction = new DepsitFunction();
            Console.WriteLine("Enter your amount to deposit Or WithDraw");
            long AccountBalance = long.Parse(Console.ReadLine());

            Console.WriteLine("To Deposit Amount Write 1 and For WithDraw Amount Write 2");
            int Select = int.Parse(Console.ReadLine());

            if (Select == 1)
            {
                depsitFunction.DepositAnount(bank, AccountNumber, AccountBalance);
            }
            else if (Select == 2)
            {
                depsitFunction.WithDrawAmount(bank, AccountNumber, AccountBalance);
            }

            else
            {
                Console.WriteLine("Invalid Choise ");
            }
            goto Again;
        }
    }
}