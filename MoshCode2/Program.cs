using System;

namespace MoshCode2
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Enter any two no.-");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());


            if (a>b)
            {
                Console.WriteLine("a is greater");
            }

            else if (a==b)
            {
                Console.WriteLine("both are same");

            }

            else
                Console.WriteLine("b is greater");
        }
    }
}
