using System;

namespace ClassesAndObjects
{
    class Student
    {

        int roll;
        string name;
        int age;
        int standard;


        public void set_student(int roll, string name, int age, int standard)
        {
            this.roll = roll;
            this.name = name;
            this.age = age;
            this.standard = standard;
        }

        public void get_student()
        {
            Console.WriteLine("Your roll no is : {0}",roll);
            Console.WriteLine("Your name no is : {0}", name);
            Console.WriteLine("Your age no is : {0}", age);
            Console.WriteLine("Your standard no is : {0}", standard);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter rollno. =");
            int roll = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name =");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age =");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter standard =");
            int standard = int.Parse(Console.ReadLine());

            Student Viraj = new Student();
            Viraj.set_student(roll,name,age,standard);

            Viraj.get_student();
        }
    }
}
