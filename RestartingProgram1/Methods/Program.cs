using System;

namespace Methods
{
    class Program
    {

        public static void Add(int num1, int num2) // parameterized method
        {
            int Value = num1 + num2;

            Console.WriteLine("The addition is = "+Value);
        }


        public static void Show_Name_Age(string name, int age)
        {
            Console.WriteLine("Your name is "+ name);
            Console.WriteLine("Your age is " + age);
        }



        public void Show() //method has been declared

//When we make a non-static method, we need to create an object 


        {
            Console.WriteLine("Hi this is Viraj Sankpal");
        }


        public static void Show1() //method has been declared

 // Non-static 
 // Instance Method

//When the method called is static then we need to call the method 
//with with class name. 

        {
            Console.WriteLine("Hello Nimap!!!!");
        }

        static void Main(string[] args)  
        {
            Program p1 = new Program();
            p1.Show();

            Program.Show1();

            Console.WriteLine("Enter first number=");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number=");
            int b = int.Parse(Console.ReadLine());

            Program.Add(a,b);

            Program.Show_Name_Age("Viraj", 21);
        }
    }
}
