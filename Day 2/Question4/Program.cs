/*  Accept two name from user and concat.*/

using System;

namespace Day2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1, name2;

            Console.WriteLine("Enter First Name:");
            name1=Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            name2 = Console.ReadLine();

            Console.WriteLine("Full Name is:{0}{1}", name1, name2);
            Console.ReadLine();

        }
    }
}
