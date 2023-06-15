using System;

namespace Constructor
{
    class Employees
    {
        int EmpId;
        string EmpName;
        int EmpAge;

        public Employees(int EmpId,string EmpName, int EmpAge)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }

        public int getID()
        {
            return this.EmpId;
        }

        public string getName()
        {
            return this.EmpName;
        }

        public int getAge()
        {
            return this.EmpAge;
        }


        static void Main(string[] args)
        {

            Employees p = new Employees(19,"Viraj",21);

            Console.WriteLine("Employee  id is :{0}",p.getID());
            
        }
    }
}
