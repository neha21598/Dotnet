/* Q3. Create  class  outdemo having method 
1.public int[] sqrarray(int[] arr, out int sum)
Job of this method is to do the sum of all element of an array. 
 * This method should store square of each elements in to new array.
 * Method should return new array.*/



using System;

namespace Day8_3
{
    class outdemo
    {
        public int[] sqrarray(int[] arr, out int sum)
           {
            sum=0;
            int[] sqr = new int[arr.Length];

            for (int i = 0; i <arr.Length; i++)
            {
                sum = sum + arr[i];
             
            }
            

            for (int i = 0; i < arr.Length; i++)
            {
                sqr[i] = arr[i] * arr[i];
            }
            return sqr;
        }
        static void Main(string[] args)
        {
            outdemo o = new outdemo();
            int [] myarr=new int[3]{1,2,3};
            int f;
            int[] a1 = new int[3];
            a1=o.sqrarray(myarr, out  f);

            Console.WriteLine("Sum is:{0}", f);

            Console.WriteLine("Square of each element is:");
            Console.Write("[");
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write("{0} ",a1[i]);
            }
            Console.WriteLine("]");
            
            Console.ReadLine();

        }
    }
}

/* OUTPUT
Sum is:6
Square of each element is:
[1 4 9 ]

*/