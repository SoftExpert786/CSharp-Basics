using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.OOPProgram.Abstraction
{
    public abstract class Personal
    {
        int Fname;
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void ShowInfo();


    }

    internal class Student : Personal
    {
        private int _id;
        private string _name;

        public int Id
        {

            set { if (value == 0)
                {
                    Console.WriteLine("Id will not be zero");
                }
                else { _id = value; } }
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value)) { Console.WriteLine("Name field will not be empty"); }
                else
                {
                    _name = value;
                }
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Student Name is {0}",_name);
            Console.WriteLine("Student Id is {0}", _id);

        }

    }
    internal class Teacher : Personal
    {
        int _id;
        string _name;
        public int Id
        {

            set
            {
                if (value == 0)
                {
                    Console.WriteLine(" Id will not be zero");
                }
                else
                {
                    _id = value;
                }
            }
            get { return _id; }
        }
        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name will not be zero");
                }
                else
                {
                    _name = value;
                }
            }
            get { return _name;}
        }


        public override void ShowInfo()
        {
            Console.WriteLine("Teacher Name is {0}", _name);
            Console.WriteLine("Teacher Id is {0}", _id);

        }
    }
}
