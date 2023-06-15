﻿using System;

namespace CopyConstrctor
{

    class Example
    {
        string name; 


        int age;

        public Example(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Example(Example e) // copy constructor   
        {
            this.name = e.name;
            this.age = e.age;
        }

        public void getData()
        {
            Console.WriteLine("Name is:{0}",name);
            Console.WriteLine("Age is:{0}", age);
        }

    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example("Viraj",21);
            obj.getData();

            Example obj1 = new Example(obj);
            obj1.getData();
        }
    }
}
