using System;

namespace MoshCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width and height resptively - ");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            if (height>width)
            {
                Console.WriteLine("The image is portrait");
            }

            else
                Console.WriteLine("The image is landscape");
        }
    }
}
