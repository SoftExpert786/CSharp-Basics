using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.OOPProgram
{
    internal class GenericConcept<T>
    {
        T _box;

        public GenericConcept(T box)
        {
            _box = box;
        }
        public T getBox()
        {
            return _box;
        }
    }
}
    internal class genericMethod{
    public static void showArray<S>(S[] Arr)
        {
            for(int i=0; i<Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    
}
