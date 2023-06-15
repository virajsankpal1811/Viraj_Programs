using System;
using System.Collections;

namespace QueuePrg
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue myQ = new Queue();

            myQ.Enqueue("Viraj");
            myQ.Enqueue(21);
            myQ.Enqueue("Satara");

            foreach (object item in myQ)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------");

            myQ.Dequeue();

            // FIFO Operation

            foreach (object item in myQ)
            {
                Console.WriteLine(item);
            }

        }
    }
}
