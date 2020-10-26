/* Q5. Accept a number from user and print square of it,
 if in put is not valid give appropriate message
*/

using System;

namespace Day2_5
{
    class Program
    {
        public void square(int a)
        {
            Console.WriteLine("Square of {0} is:{1}", a, a * a);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();

            string num;
            int f;

            Console.WriteLine("Enter a number:");

            num = Console.ReadLine();
            bool a1 = int.TryParse(num, out f);

            if (a1 == true)
            {
                p1.square(f);
            }

            else
            {
                Console.WriteLine("Enter a valid number:");
            }

            Console.ReadLine();
        }
    }
}
