/*  Accept 5 element in an array and copy it to another array.*/

using System;

namespace Day7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = new int[5];
            int[] cpy = new int[5];

            Console.WriteLine("Enter 5 elements:");
            for (int i = 0; i < 5; i++)
            {
                myarr[i] = int.Parse(Console.ReadLine());
            }

            myarr.CopyTo(cpy, 0);

            Console.WriteLine("\n Copied array elements are:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(cpy[i] + "\t");
            }

            Console.ReadLine();

        }
    }
}



