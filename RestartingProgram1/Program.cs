using System;

namespace RestartingProgram1
{
    class Program
    {
        static void Main(string[] args)
        {

            string confirm;

            do
            {
                Console.WriteLine("Enter first number=");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second number=");
                int num2 = int.Parse(Console.ReadLine());

                int add = num1 + num2;

                Console.WriteLine("Addition result is:" + add);

                Console.WriteLine("Do you want to reapeat the program");
                confirm = Console.ReadLine().ToLower();

            } while (confirm=="yes");

        }
    }
}
