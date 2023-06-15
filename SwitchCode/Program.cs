using System;

namespace SwitchCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int week = 9;

            int age = int.Parse(Console.ReadLine());             
          switch (age)
            {
                case 15:
                     Console.WriteLine("Your are not eligible to vote");
                        break;

                case 16:
                    Console.WriteLine("You can't vote");
                    break;

                case 18:
                    Console.WriteLine("You are eligible to vote");
                    break;

                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }

        }
    }
}
