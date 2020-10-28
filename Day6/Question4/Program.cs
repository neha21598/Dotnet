using System;

namespace Day_6_4_Console
{
    class Array_Matrix
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Enter Size of Array");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            int[] sqrarr = new int[size];

            Console.WriteLine("Enter The Elements of an Array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum = sum + arr[i];
            }

            Console.WriteLine("The sum of Array is {0}", sum);

            Console.WriteLine("The Square of Each Element of Array is :");
            Console.Write("[");
            for (int i = 0; i < size; i++)
            {
                sqrarr[i] = (arr[i]) * (arr[i]);
                Console.Write(sqrarr[i] + ",");
            }
            Console.Write("]");
            Console.ReadLine();

        }
    }
}                      
