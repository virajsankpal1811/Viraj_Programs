using System;

namespace NestedIfelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;

            if (a>5)
            {
                if(a==10)
                {
                    Console.WriteLine("a is 10");
                }

                else
                {
                    Console.WriteLine("a is not 10");
                }
            }

            else
            {
                Console.WriteLine("a is lesser");
            }
        }
    }
}
