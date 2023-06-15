using System;

namespace Anonymous
{

    public delegate void MyDelegate(int num);


    class Program
    {


        public static void MyMethod(int a)
        {
            a += 10;
            Console.WriteLine(a);
        }


        static void Main(string[] args)
        {

            MyDelegate obj = new MyDelegate(Program.MyMethod);
            obj.Invoke(5);


        }
    }
}
