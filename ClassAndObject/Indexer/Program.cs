using System;
namespace IndexerProgram
{
    class Student
    {
        private string[] StudentName=new string[4];
        public string this[int index]
        {
            get { return StudentName[index]; }
            set { StudentName[index] = value; }
        }
    }
    class main
    {
        static void Main(String[] args)
        {
            Student student = new Student();
            Console.WriteLine("Enter Student Nsme");
            for (int i = 0; i < 4; i++) {
                student[i] = Console.ReadLine();
                
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(student[i]);
            }



            }
    }
}