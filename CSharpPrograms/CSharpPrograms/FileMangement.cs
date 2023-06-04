using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpPrograms
{
    internal class FileMangement
    {
        public static void fileFunc()
        {
            try
            {
                string path = @"E:\File.txt";
                using (FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    //string data = "I am here for doing some task"; //create a string
                    //byte[] Writedata=Encoding.UTF8.GetBytes(data);  //Convert data into bytes using GetBytes method and encoding into UTF8 then insert in array
                    //fileStream.Write(Writedata, 0, Writedata.Length); //Write it in file using write method of FileAcces
                    //  fileStream.WriteByte(54);
                    using (StreamWriter sr = new StreamWriter(fileStream))
                    {
                        char[] buffer = { 'A', 'B', 'C', 'D', 'E', 'F' };
                        foreach (char c in buffer)
                        {
                            sr.WriteLine(c);
                        }
                        // sr.WriteLine("I am hare to Write Some thing");
                        // sr.WriteLine("I am hare to Write Some thing");
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

        }
        public static void Readr()
        {
            try
            {
                string Path = @"E:\File.txt";
                using (FileStream fileStream = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fileStream))
                    {
                        //  string line = "";
                        //while (line == sr.ReadLine() != null)
                        //{
                        //  Console.WriteLine(line);
                        //}
                        //using this we can read all lines charactor by charactor
                        // foreach(var c in sr.ReadLine())
                        // {
                        //   Console.WriteLine(c);
                        //}
                        string[] names =  new string[5];
                        for (int i = 0; i <names.Length; i++)
                        {
                            names[i] = sr.ReadLine();
                        }
                        foreach (var name in names)
                        {
                            Console.WriteLine(name);
                        }
                        string data = sr.ReadToEnd();

                        
                    }
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
    }
}

