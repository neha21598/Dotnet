/* Declare 2  variable of a type byte and print product of it.*/

using System;

namespace Day1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 2;
            byte num2 = 2;

            byte product = (byte)(num1 * num2);
            Console.WriteLine("Product is:{0}", product);
            Console.ReadLine();

        }
    }
}
