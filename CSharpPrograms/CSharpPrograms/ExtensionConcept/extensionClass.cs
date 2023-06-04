using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.ExtensionConcept
{
    internal static class extensionClass
    {
        public static void func3(this defualtClass Pa)
        {
            Console.WriteLine("func3");
        }
    }
}
