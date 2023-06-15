using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.stringProgram
{
    internal class CNICDetail
    {
        public static void CNIC()
        {
            Console.WriteLine("Enter your CNIC Number xxxxx-xxxxxxxx-x");
            string IdNo = Console.ReadLine();
            Console.WriteLine("1st five digit tell about your province,division ,Tehsil ,city and Union");
            char Pro = IdNo[0];
            switch (Pro)
            {
                case '1': Console.WriteLine("You belong to KPK Province");
                    break;
                case '2':
                    Console.WriteLine("You belong to FATA Province");
                    break;
                case '3':
                    Console.WriteLine("You belong to Punjab Province");
                    break;
                case '4':
                    Console.WriteLine("You belong to Sindh Province");
                    break;
                case '5':
                    Console.WriteLine("You belong to Baluchistam Province");
                    break;
                case '6':
                    Console.WriteLine("You belong to Islamabad Province");
                    break;
                case '7':
                    Console.WriteLine("You belong to Giligit Baltistan Province");
                    break;
                default: Console.WriteLine("You enter Wrong ID card number ");
                    break;
            }
            char Divsion=IdNo[1];
            switch (Divsion)
            {
                case '2':
                    Console.WriteLine("You belong to DGkhan Division");
                    break;
                case '3':
                    Console.WriteLine("You belong to Multan Division");
                    break;
                default:
                    Console.WriteLine("You belong to division");
                    break;
            }

        }
    }
}
