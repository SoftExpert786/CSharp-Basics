using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.Collection.Generic
{
    internal class DictionaryFun
    {
        public static void DictionaryMethod() {
            Dictionary<int, string> myDict = new Dictionary<int, string>()
{
    {1,"tiger" },
    {2,"Lion" },
    {3,"Dog" }
};
            myDict.Add(5, "Cat");
            foreach (KeyValuePair<int,string> item in myDict)
            {
                Console.WriteLine( item.Key +" value" +item.Value );
                            

            }
            Console.WriteLine("----------------");
            foreach(int item in myDict.Keys)
            {
                Console.WriteLine(item);
            }

    }
    }
}