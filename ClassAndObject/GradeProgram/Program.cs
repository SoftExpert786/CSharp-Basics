using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter your Physic marks");
            int phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Math marks");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Chemistry marks");
            int Chem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Biology marks");
            int bio = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Urdu marks");
            int urdu = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your English marks");
            int En = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Islamiyat marks");
            int Is = int.Parse(Console.ReadLine());
            long sum = phy + math + Chem + En + bio + urdu + Is;
            int ave = (int)sum / 7;
            if (ave >= 90 && ave <= 100)
            {
                Console.WriteLine("Your Grade is A+");
            }
            else if (ave >= 80 && ave <= 90)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (ave >= 70 && ave <= 80)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (ave >= 60)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (ave >= 50 && ave <= 60)
            {
                Console.WriteLine("Your Grade is D");
            }
            else Console.WriteLine("Try next time");

            Console.WriteLine("if you want to re-enter data write true");
            bool tryagain = bool.Parse(Console.ReadLine());
            if (tryagain)
            {
                goto start;
            }
            else { Console.Read(); }




        }
    }
}
