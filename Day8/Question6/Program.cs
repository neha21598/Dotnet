/* Q6. Create a class mymath having method sum who’s job is to find average.
 * This method should work even if it’s called with different number of arguments eg. sum(4,5) ,sum(4,7,8,9)*/


using System;

namespace Day8_6
{
    class mymath
    {
        public void sum(params int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
                
            }
            int average = sum / num.Length;
            Console.WriteLine("Average is:{0}", average);
        }

        static void Main(string[] args)
        {
            mymath m = new mymath();
            m.sum(2, 3, 4);
            m.sum(2, 3);
            Console.ReadLine();

        }
    }
}
