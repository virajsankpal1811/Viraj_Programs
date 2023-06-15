using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            HashTbl ht = new HashTbl();
            ht.Add("id", 1811);
            ht.Add("name","Viraj" );
            ht.Add("salary", 50000);

            Console.WriteLine(ht["id"]);

        }
    }
}
