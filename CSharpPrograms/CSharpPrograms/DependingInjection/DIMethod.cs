using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.DependingInjection
{
	public interface IAccountM 
	{
		void PrintDetails();
	}
	class CurrentAccountM : IAccountM
	{
		public void PrintDetails()
		{
			Console.WriteLine("Current");
		}
	}
    class SavingAccountM : IAccountM
    {
        public void PrintDetails()
        {
            Console.WriteLine("Current");
        }
    }
	class AccountM
	{
		public void PrintAccount(IAccountM accountM)
		{
			accountM.PrintDetails();
		}
	}


}

