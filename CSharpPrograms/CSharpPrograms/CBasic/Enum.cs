using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic
{
    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    internal class EnumC
    {
        public static void Func()
        {
            string[] member = (string[])Enum.GetNames(typeof(Days));
            foreach (var item in member)
            {
                Console.WriteLine(item);
            }
           

            
        }
    }
}
