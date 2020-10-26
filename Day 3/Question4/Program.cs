/* Accept a number from user and display its type and parent class */

using System;

namespace Day_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            Console.WriteLine("Enter a number:");
            string num;
            num = Console.ReadLine();
            bool a1=int.TryParse(num,out f);
            Console.WriteLine("Type of number{0} is:{1}",f,f.GetType());//To print type
            Console.WriteLine("Parent class of {0} is:{1}",f,f.GetType().BaseType);//To print parent class
            Console.ReadLine();
        }
    }
}
