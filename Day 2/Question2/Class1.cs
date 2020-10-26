/*Create a class library which will return square, cube of a number. [Create private Assembly]*/

using System;

namespace Day_2_2_lib
{
    public class Class1
    {
        public void square(int a)
        {
            Console.WriteLine("Square of {0} is:{1}", a, a * a);
        }

        public void cube(int a)
        {
            Console.WriteLine("cube of {0} is:{1}", a, a * a * a);
        }
    }
}
