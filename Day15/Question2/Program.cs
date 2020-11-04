/* Accept 5 element in an array having duplicate value print unique array.*/

using System;
using System.Collections.Generic;

namespace Day15_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 2, 3, 4 };

            Console.WriteLine("Array ELements Are:");
            foreach (int i in arr)
                Console.WriteLine("{0}", i);

       HashSet<int> myset=new HashSet<int>();
       myset.Add(arr[0]);
       myset.Add(arr[1]);
       myset.Add(arr[2]);
       myset.Add(arr[3]);
       myset.Add(arr[4]);

       Console.WriteLine("Unique Elements Are:");
       foreach (int i in myset)
           Console.WriteLine("{0}", i);

       Console.ReadLine();

           
        }
    }
}
