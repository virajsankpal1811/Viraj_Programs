using System;

namespace InitializingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many number of items you want to store in an array=");
            int num = int.Parse(Console.ReadLine());

            int[] numbers = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("enter data=");
                int data = int.Parse(Console.ReadLine());
                numbers[i] = data;

            }

            Console.WriteLine("----------Your Data----------");
            foreach (int items in numbers)
            {
                Console.WriteLine(items);
            }
        }
    }
}
