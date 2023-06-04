using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.Collection
{
    internal class QueueConcept
    {
        public static void QueueMethod()
        {
            // Queue use FiFo method 
            Queue queue = new Queue();
            queue.Enqueue("Zain");   //will add data
            queue.Enqueue("Alvi");
            queue.Enqueue(12);
            queue.Enqueue("Add");
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(  "--------------");
            while (queue.Count > 0)   //coubnt property will count the data in Queue
            {
                Console.WriteLine(queue.Dequeue());      //Dequeue method will Return and remove data from Queue
            }


        }
    }
}
