/* Q1. Create a static class Mymeth having two static  method
	1. public int sqr(int n) :this method return square of a number
	2. public double sqr(double s): this method return square of a number
Create a entry point class and call this method.*/

using   System;

namespace Day8_1
{
    static class Mymath
    {
        public static int sqr(int n)
        {
            return n * n;
        }
        public static double sqr(double s)
        {
            return s * s;

        }
        
        static void Main(string[] args)
        {
            int res1=sqr(2);
            Console.WriteLine("Square of 2 is:{0}", res1);

            double res2=sqr(2.2);
            Console.WriteLine("Square of 2.2 is:{0}", res2);

            Console.ReadLine();
        }
    }
}
