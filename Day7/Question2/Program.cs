/* Accept5 element in an array and sort descending order*/

using System;

namespace Day7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = new int[5];
            Console.WriteLine("Enter 5 elements:");
            for (int i = 0; i < 5; i++)
            {
                myarr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Before Sorting Array Elements are:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(myarr[i] + "\t");
            }

            Array.Sort(myarr);
            Array.Reverse(myarr);
            Console.WriteLine("\n After descending sorting Array Elements are:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(myarr[i] + "\t");
            }

            Console.ReadLine();

        }
    }
}



