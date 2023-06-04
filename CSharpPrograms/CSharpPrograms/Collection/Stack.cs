using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.Collection
{
    internal class StackF
    {
        public static void stackMethod()
        {
            Stack stackobj = new Stack();   //create obj of Stack 
            stackobj.Push("ali");       // Add data in the stack
            stackobj.Push(1234);
            stackobj.Push("Raza");
            
            foreach (var item in stackobj)
            {
                Console.WriteLine(item);
            }
            stackobj.Pop();        // will remove data t the top of the stack
            Console.WriteLine("-------------------");
            foreach (var item in stackobj)
            {
                Console.WriteLine(item);
            }


        }
    }
}
