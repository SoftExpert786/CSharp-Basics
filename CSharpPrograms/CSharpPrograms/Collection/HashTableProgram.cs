using System;
using System.Collections;

namespace CSharpPrograms.Collection
{
    internal class HashTableProgram
    {
        public static void HashtableMethod()
        {
            Hashtable ht = new Hashtable()
        {  //using this method can add multiple values in hashtable
            {"Id",1234 },
            {"F_Name","Zain"},
            {"S_Name","Alvi" },
             {"Email","Zain@gmail.com" },
            {"Ph",1234 }
        };
            foreach (object key in ht.Keys)   // keys is property of Hashtable use to get key of table we can use value property to get Value
            {
                Console.WriteLine(key + ":" + ht[key]);
                
            }
            ht.Add("Age", 25);    // use this method to add signal key (key,value)
            ht.Remove("ph");     // Use   this method to remove Any Value using key 
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + ":" + ht[key]);

            }
            Console.WriteLine(ht.Count); //count the values of Hashtable
            Console.WriteLine(ht.ContainsValue("zain")); // method will return bollen value if value exist true
            Console.WriteLine(ht.ContainsKey("ph"));// also boolen value  for key
        }
	}


    }
