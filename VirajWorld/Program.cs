using System;

namespace VirajWorld
{
    public class person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is "+FirstName+LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var john = new person();
            john.FirstName = "Viraj";
            john.LastName = "Sankpal";
            john.Introduce();


        }
    }
}
