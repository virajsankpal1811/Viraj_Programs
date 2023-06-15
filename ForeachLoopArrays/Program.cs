using System;

namespace ForeachLoopArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = new int [4];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            //string[] names = new string[4];
            //names[0] = "Viraj";
            //names[1] = "Soma";
            //names[2] = "Vivek";
            //names[3] = "Prasad";


            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //  Console.WriteLine(numbers[i]);
            //}

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
