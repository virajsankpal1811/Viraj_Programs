using System;

namespace Properties
{

    class Student
    {
        private int _StdId;
        private string _Name;
        private string _Fname;
        private int _TotalMarks = 100;


        public int TotalMarks        {
            get
            {
                return this._TotalMarks;
            }
        }


        public int StdId
        {
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    this._StdId = value;

                }
            }

            get
            {
                return this._StdId;
            }
        
        }



        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("please enter your name!!!");
                }
                else
                {
                    this._Name = value;
                }
            }


            get
            {
                return this._Name; 
            }
        }




        public string FName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("please enter your father name!!!");
                }
                else
                {
                    this._Fname = value;
                }
            }


            get
            {
                return this._Fname;
            }
        }



    }


    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student();
            s.StdId = 19;
            s.Name = "Viraj";
            s.FName = "Vishwanath";
            Console.WriteLine(s.StdId);
            Console.WriteLine(s.Name);
            Console.WriteLine(s.FName);


        }
    }
}
