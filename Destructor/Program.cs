using System;

namespace Destructor
{

    class person
    {
        public string name;
        public int age;

        public person(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        public string getname()
        {
            return this.name;
        }

        public int getage()
        {
            return this.age;
        }

        ~person()
        {
            Console.WriteLine("Destructor has been invoked");
        }



    }


    class Program
    {
        static void Main(string[] args)
        {

            person Viraj = new person("viraj", 21);
            Console.WriteLine(Viraj.getname());
            Console.WriteLine(Viraj.getage());


        }
    }
}
