using System;

namespace Calculator
{
    class Program
    {

        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition Result is: {0}",result);
        }

        public static void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction Result is: {0}", result);
        }

        public static void Mul(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication Result is: {0}", result);
        }

        public static void Div(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division Result is: {0}", result);
        }

        static void Main(string[] args)
        {

            Console.WriteLine( "Enter first number=");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number=");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator(+,-,*,/)");

            string op = Console.ReadLine();

            if(op.Equals("+"))
            {
                Program.Add(num1, num2);
            }

            else if (op.Equals("-"))
            {
                Program.Sub(num1, num2);
            }

            else if (op.Equals("*"))
            {
                Program.Mul(num1, num2);
            }

            else if (op.Equals("/"))
            {
                Program.Div(num1, num2);
            }

            else
            {
                Console.WriteLine("Invalid Operation");
            }


        }
    }
}
