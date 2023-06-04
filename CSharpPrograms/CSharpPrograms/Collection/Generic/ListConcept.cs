using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.Collection.Generic
{
    internal class ListConcept
    {
        public static void ListMethod()
        {
            List<string> list = new List<string>()     //create object of List 
            {// can add multiple data also use Add method to Add data
                "zain",
                "Alvi",
                "Adnan"
            };
            Console.WriteLine(list.Capacity);   //check the length of list
          foreach (var item in list)
            {
                Console.WriteLine(item);
            }
          Console.WriteLine("----------------");
            StudentM student = new StudentM()        // create obj  model class 
            {//  enter data in field of model class
                Id = 1,
                Name = "Zain",
                Desination="Manger"
            
            };
            StudentM student1 = new StudentM()
            {
                Id = 1,
                Name = "Zain",
                Desination = "Manger"

            };

            List<StudentM> students = new List<StudentM>();   // create list Which data type is a model class
            students.Add(student);      // add data using student object
            students.Add(student1);
            foreach (StudentM item in students)
            {
                Console.WriteLine("Student Id is {0}  Student name is {1}  Student Desination is {2}",item.Id,item.Name,item.Desination);
            }
        }
    }
}
