/* Declare a variable of a type float and print square
 of it after storing it in to a variable.
*/

using System;

namespace Day1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 2.5f;
            
            float square = num1 *num1;
            Console.WriteLine("square is:{0}", square);
            Console.ReadLine();
        }
    }
}
