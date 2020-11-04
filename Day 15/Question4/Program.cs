/* Accept 5 name from user and store it in an array store all name starting from “v” in to another array and print  eg input [vita, vidya, dac, edac,dbda] O/P [vita, vidya]
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            string[] arr = new String[2];

            for (int i = 0; i < arr.Length; i++)
               arr[i]= Console.ReadLine();

            Console.WriteLine("\nArray Elements are:");
            foreach (string i in arr)
                Console.WriteLine(i);

            HashSet<string> myset = new HashSet<string>();
            myset.Add(arr[0]);
            myset.Add(arr[1]);

            var vdata=myset.Where(data => data.StartsWith("V"));

            Console.WriteLine("\n Names starting with V are:");
            foreach (string i in vdata)
                Console.WriteLine(i);

            Console.ReadLine();

        }
    }
}

/* OUTPUT
Enter Name:
Vidya
Nidhi

Array Elements are:
Vidya
Nidhi

 Names starting with V are:
Vidya

*/