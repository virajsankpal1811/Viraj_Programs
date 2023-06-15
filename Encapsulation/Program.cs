using System;

namespace Encapsulation
{


    class person
    {
        private string Name;
        private int Age;


        public void setName(string Name)
        {
            this.Name = Name;

        }

        public void getName()
        {
            Console.WriteLine("Your name is "+ this.Name);

        }
    }



    class Program
    {
        static void Main(string[] args)
        {


            person p = new person();
            p.setName("Viraj");
            p.getName();



        }
    }
}
