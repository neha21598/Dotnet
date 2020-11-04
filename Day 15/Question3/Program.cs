/* Accept 5 element in an array and store all even number in another array and print. Use lambda 
 * */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day15_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5]{1,2,3,4,5};

            List<int> mylist = new List<int>();
            mylist.Add(arr[0]);
            mylist.Add(arr[1]);
            mylist.Add(arr[2]);
            mylist.Add(arr[3]);
            mylist.Add(arr[4]);

            Console.WriteLine("Array Elements are:");
            foreach (int i in mylist)
                Console.WriteLine(i);
          

          var even   = mylist.Where(Num => Num % 2 == 0);

          Console.WriteLine("Even numbers are:");
          foreach (int i in even)
           Console.WriteLine(i);
              
          


            Console.ReadLine();

            
                


        }
    }
}
