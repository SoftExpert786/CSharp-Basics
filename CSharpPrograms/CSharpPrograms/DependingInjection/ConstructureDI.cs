using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.DependingInjection
{
    // create a interface to make dependenecing injection 
   public interface IAccount
    {

        void PrintDetail();

    }
    //create a c;lass which is inheritance from the interface
    public class CurrentAccount : IAccount
    {
        public void PrintDetail()
        {
            Console.WriteLine("Curent Account ");
        }
    }
  public  class SavingAccount : IAccount
    {
        public void PrintDetail()
        {
            Console.WriteLine("Saving Account ");
        }
    }
       public class Account
        {
        // create a variable of type IAccount Interface 
            private IAccount account;
        // for constructor DI cteate a Constuctor Which take a parameter of type IAccount type
        public Account(IAccount account)
        {
            this.account = account;
        }
        public void DetailAccount()
        {
            account.PrintDetail();
        }
        }
    
    
}