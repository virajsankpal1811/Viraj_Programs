using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading;

namespace Generic_lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> myNumbers = new List<int>();

            myNumbers.Add(11);
            myNumbers.Add(22);
            myNumbers.Add(33);

            foreach (object item in myNumbers)
            {
                Console.WriteLine( item);
            }
             

          
        }
    }
}
