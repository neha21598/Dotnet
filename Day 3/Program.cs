/* Q1. Create a struct Math having two static method square and cube. Using struct variable call this method and print 
 * square and cube of a number*/

using System;

namespace Day3_1
{
    struct Math
    {
        public static void square(int a)
        {
            Console.WriteLine("Sqaure is:{0}", a * a);
        }

        public static void cube(int a)
        {
            Console.WriteLine("Cube is:{0}", a* a * a);
        }
    
        static void Main(string[] args)
        {
            Math.square(2);

            Math.cube(2);
            Console.ReadLine();
        }
    }
}
