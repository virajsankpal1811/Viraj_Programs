using System;

namespace StringCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Viraj";

            var lastName = "Sankpal";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);


            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);


            var names = new string[3] { "Viraj", "Somanath", "Vivek" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi Viraj\n Look into the following paths\n c\\folder1\\folder2";
            Console.WriteLine(text);


        }
    }
}
