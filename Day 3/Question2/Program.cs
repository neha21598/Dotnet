/* Q2. Accept a number from user and pass it to static method of a struct calculator it should print all factor of a number.*/

using System;

namespace Day3_2
{
    struct Calculator
    {
        public static void Factorial(int num)
        {
            Console.WriteLine("Factors of a number are:");
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            string num;
            int f;
            Console.WriteLine("Enter a number:");
            num=Console.ReadLine();
            bool a1 = int.TryParse(num, out f);
            if (a1 == true)
            {
                Calculator.Factorial(f);
            }
            Console.ReadLine();
        }
    }
}
