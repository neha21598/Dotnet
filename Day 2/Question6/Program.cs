/*  Accept a number and stored it in byte data type check what happen if you enter 258?*/

using System;

namespace Day2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            byte f;

            Console.WriteLine("Enter number:");

            checked
            {
                num = Console.ReadLine();
                bool a1 = byte.TryParse(num, out f);
                Console.WriteLine(f);
                Console.ReadLine();
            }
        }
    }
}