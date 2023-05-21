namespace CSharpPrograms.OOPProgram.EncapSulation
{
    class Bank
    {
        public static decimal AccountBalane=1000;
        public  decimal SetAccountBalance
        {
            get { return AccountBalane; }
            set { AccountBalane = value; }
           
        }
       

    }
    internal class BankAccount
    {
        private static int AccountNumber = 12345678;
            

        public static void CheckBalance(Bank bank)
        {
            decimal  AccountBalance = bank.SetAccountBalance;
            Console.WriteLine("Your Account Balance is {0}", AccountBalance);
        }
        public static void DepositBalance(int _AccountBalance,decimal AccountBalance)

        {
            if (AccountNumber == _AccountBalance)
            {
                Bank bank = new Bank();
                decimal balance = 0;
                balance= bank.SetAccountBalance + AccountBalance;
                Console.WriteLine("Your Account Balance is {0}",balance);

                
            }
            else
            {
                Console.WriteLine("Your Account number is not correct");
            }
            

        }
        public static void WithdrawBalance(int _AccountNumber,decimal Amount)
        {
            if (_AccountNumber == AccountNumber)
            {
                Bank bank=new Bank();
                decimal AccountBalance = bank.SetAccountBalance;
                if (Amount< AccountBalance)
                {
                    Console.WriteLine("You have insufisunt Balance in your Account");
                }
                else
                {
                    decimal amount;
                    amount= bank.SetAccountBalance-Amount;
                    Console.WriteLine("Your Account Balance is {0}",amount);
                }
            }
        }
    }
}
