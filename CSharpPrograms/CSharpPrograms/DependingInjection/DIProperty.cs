using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.DependingInjection
{
	interface IAccountP 
	{
		void printDetails();
	}
	class SavingAccountp : IAccountP
	{
		public void printDetails()
		{
			Console.WriteLine("Saving Account");
		}

	}
	class CurrentAccountp : IAccountP
	{
        public void printDetails()
        {
            Console.WriteLine("Current Account");
        }
    }
 class AccountP
	{
		public IAccountP accountP { get; set; }
		public void DetailAccounts()
		{
			accountP.printDetails();	
		}
	}
}
