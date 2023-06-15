using System;
using System.Collections;


namespace HashTableProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();

            ht.Add("id",1811);
            ht.Add("name","Viraj");
            ht.Add("salary",50000);
            ht.Add("age", 21);


            //{  ANOTHER WAY
            //    {"id",1811},
            //    {"name","Viraj"}
            //};

            Console.WriteLine(ht["name"]);

        }
    }
}
