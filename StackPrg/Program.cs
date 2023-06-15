using System;
using System.Collections;


namespace StackPrg
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack mystack = new Stack();
            mystack.Push("Viraj");
            mystack.Push(5.11);
            mystack.Push(21);
            

            foreach (object item in mystack)
            {
                Console.WriteLine(item);
                
                // LIFO Operation !!!
            }
            Console.WriteLine("---------------------------------------");


            mystack.Pop();

            foreach (object item in mystack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
