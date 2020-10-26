/* Q6. Create a class having instance member salary. Create a object of a class. Print data type of reference of a class also print
 * parent class name.*/

using System;

namespace Day_3_5
{
    class program
    {
        double salary;

        static void Main(string[] args)
        {
            program p1 = new program();
            Console.WriteLine("Data type of reference is:{0}",p1.GetType());
            Console.WriteLine("Base type of reference is:{0}", p1.GetType().BaseType);
            Console.ReadLine();
        }
    }
}
