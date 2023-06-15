using System;

namespace ValueAndReferenceType
{


    struct Employee
    {
        public int salary;
        public int age;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.salary = 5000;
            e.age = 21;

            Employee e1 = e;
            Employee e2 = e;

            e.age = 25;
            Console.WriteLine(e1.age);
            Console.WriteLine(e2.age);



        }
    }
}
