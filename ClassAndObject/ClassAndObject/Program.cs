using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Program
    {
        internal class Personal
        {
            private string _name;
            private int _age;
            private string _email;
            public void get(string name, int age, string email)
            {

                this._name = name;
                this._age = age;
                this._email = email;
            }
            public void set()
            {
                Console.WriteLine("    Personal Detail     ");
                Console.WriteLine("Name of  personal is {0}", this._name);
                Console.WriteLine("Age of  person is {0}", this._age);
                Console.WriteLine("Email of  personal is {0}", this._email);
                
            }


        }

        static void Main(string[] args)
        { 
            start:
            Console.WriteLine("Enter Your  Name of ");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter Your  Age of ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your  Email of ");
            string? email = Console.ReadLine();
            
            Personal personalObj = new Personal();
            personalObj.get(name , age,email);
            personalObj.set();
            Console.WriteLine("Are You want more Detail Write yes");
            string tryagain =Console.ReadLine();
            if(tryagain == "Yes")
            {
                goto start;
            }
            
        }
    }
}
