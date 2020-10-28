/* Accept a name from user accept password and confirm password from user if password and confirm
 * password string are same give message valid data else print invalid data.*/

 

using System;

namespace Day7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();

            Console.WriteLine("Enter Confirm Password:");
            string confirm_pass = Console.ReadLine();

            if (object.Equals(pass, confirm_pass))
                Console.WriteLine("VALID USERNAME AND PASSWORD");

            else
                Console.WriteLine("INVALID DATA");

            Console.ReadLine();

        }
    }
}
