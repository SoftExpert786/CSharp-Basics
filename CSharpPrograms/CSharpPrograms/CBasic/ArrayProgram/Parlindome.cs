using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic.ArrayProgram
{
    internal class Parlindome
    {
        public static void parl()
        {
            try
            {
                string Word = "";
                Console.WriteLine("Enter your word");
                Word = Console.ReadLine();
                char[] ar = Word.ToCharArray();
                Array.Reverse(ar);
                string Str_Reverse = new string(ar);
                Console.WriteLine(Word + " =>" + Str_Reverse);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
