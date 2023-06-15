using System;

namespace TypesOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {   // Jagged Array

            int[][] arr1 = new int[3][];
            arr1[0] =new[] {1,2,3,4,5};
            arr1[1] =new[] {6,7,8,9};
            arr1[2] =new[] {11,12,13,14,15,16};

            foreach (int[] items in arr1)
            {
                foreach (int i in items )
                {
                    Console.WriteLine(i+" ");
                }
            }


            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j <arr1[i].Length; j++)
            //    {
            //        Console.Write(arr1[i] [j] + " ");
            //    }
            //    Console.WriteLine("");
            //}


            // Console.WriteLine(arr1[2][5]);






            // Rectangular Array
            //int[,] my_array = new int[3, 4]
            //{
            //        {1,2,3,4},
            //        {5,6,7,8},
            //        {9,10,11,12}
            //};

            //foreach (int item in my_array)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < my_array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < my_array.GetLength(1); j++)
            //    {
            //        Console.Write(my_array[i,j]+" ");
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine(my_array[2,0]);
            //Console.WriteLine(my_array.GetLength(1));
            //Console.WriteLine(my_array.Rank);
        }
    }
}
