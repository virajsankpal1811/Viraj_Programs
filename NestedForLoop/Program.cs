using System;

namespace NestedForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=3; i++)
            {
                Console.WriteLine("Hello");

                for (int j = 1; j <=3; j++)
                {
                    Console.WriteLine("Hey");
                }
            }
        }
    }
}
