﻿using System;

namespace ReferenceAndValues
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(array2[0]);
            Console.WriteLine(array1[0]);

        }
    }
}
