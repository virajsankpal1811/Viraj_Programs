using System;

namespace Inheritance
{

    class visit : employees
    {
        public int visitingsalary;
        public int visitinghours;

    }


    class permanent : employees
    {

        public int persalary;
        public int perhours;

    }


    class employees
    {
        public int EmpId;
        public string Empname;
        public int Empage;
        public long  Empphn;
    }

    class Program
    {
        static void Main(string[] args)
        {

            permanent p = new permanent();
            p.EmpId = 12;
            p.Empname = "Viraj";
            p.Empage = 21;
            p.Empphn = 9876543456;


            Console.WriteLine(p.EmpId);

        }
    }
}
