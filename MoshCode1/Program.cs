using System;

namespace MoshCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number-");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num> 1 && num<=10)
            {
                Console.WriteLine("Valid");
            }

            else
                Console.WriteLine("Invalid");
        }
    }
}
