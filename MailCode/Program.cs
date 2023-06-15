using System;

namespace MailCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter your email=");
            string email = Console.ReadLine();

            if (email=="viraj19@hotmail")
            {
                Console.WriteLine("Enter your password=");
                string pass = Console.ReadLine();

                if (pass== "Viraj@1234")
                    {
                     Console.WriteLine("Login Successfully");
                    }
                else
                    {
                    Console.WriteLine( "Incorrect Password"); 
                    }
            }

            else
            {
                Console.WriteLine("Invalid mail address");
            }

        }
    }
}
