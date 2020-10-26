/* Q5. Create a class calculator having  static method square, cube, absolute, floor,ceil who’s job is to find square, cube, 
 * absolute (2.2 ==2)floor(eg. 2.7==O/P==2) , Ceil(eg 2.9==3) value respectively.*/

using System;

namespace Day4_5_lib
{
    public class Calculator
    {
        static Calculator()
        {
            Console.WriteLine("*********In Calculator Class***********");
        }
        public static void square(int a)
        {
            Console.WriteLine("Square is:{0}",a*a);
        }

        public static void cube(int a)
        {
            Console.WriteLine("Cube is:{0}",a*a*a);
        }
    
        public static void absolute(int a)
        {
            Console.WriteLine("Absolute value  is:{0}",Math.Abs(a));
        }
    
        public static void floor(double a)
        {
            Console.WriteLine("Floor value is:{0}",Math.Floor(a));
        }
    
        public static void ceil(double a)
        {
            Console.WriteLine("Ceil value is:{0}",Math.Ceiling(a));
        }
    
    }
}
