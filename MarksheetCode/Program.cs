using System;

namespace MarksheetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name=");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your roll no.=");
            string roll = Console.ReadLine();

            Console.WriteLine("Enter your class=");
            string classname = Console.ReadLine();

            Console.WriteLine("Enter English marks=");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Math marks=");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Physics marks=");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Chemsistry marks=");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Biology marks=");
            int b = int.Parse(Console.ReadLine());


            int obt = e + p + m + c + b;

            int per = (obt * 100 )/ 500;

            Console.WriteLine("your obtained marks are : {0}",obt);
            Console.WriteLine("your percetange scored is :{0}",per);


            if(per>=80)
            {
                Console.WriteLine("Grade:A1");
            }

            else if (per >= 70)
            {
                Console.WriteLine("Grade:A2");
            }

            else if (per >= 60)
            {
                Console.WriteLine("Grade:B");
            }

            else if (per >= 50)
            {
                Console.WriteLine("Grade:C");
            }

            else if (per >= 35)
            {
                Console.WriteLine("Grade:D");
            }

            else
            {
                Console.WriteLine("Fail");
            }




        }
    }
}
