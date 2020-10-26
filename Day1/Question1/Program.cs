/* Q1. Declare 2 variable of a type short and store sum 
of it in a variable and print it.
 * */

using System;

namespace Day1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1 = 2;
            short num2=2;

           short sum =(short) (num1 + num2);
            Console.WriteLine("Sum is:{0}",sum);
            Console.ReadLine();
        }
    }
}
