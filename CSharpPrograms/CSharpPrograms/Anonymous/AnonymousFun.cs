using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.Anonymous
{
    
        public delegate void myDelegates(int a);
        class program
        {
            public static void Add(myDelegates obj,int a)
            {
                a += 10;
            obj(a);
                Console.WriteLine(obj);
            }
        }
      
    }

