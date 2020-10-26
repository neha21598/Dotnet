/*Q1. Accept two number from user and print sum of it.*/

using System;

namespace Day2_1
{
    class Program
    {
        
        public void sum(int a, int b)
        {
            Console.WriteLine("Sum is:{0}", a + b);
        }
        static void Main(string[] args)
        {

            Program p1 = new Program();

            int f, g;
            string num1, num2;
            Console.WriteLine("Enter Two numbers:");
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();

            bool a1 = int.TryParse(num1, out f);
            bool a2 = int.TryParse(num2, out g);

            p1.sum(f, g);

            Console.ReadLine();

        }
    }
}
