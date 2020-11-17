/*
 * 1. create  a  static class having static method to find
	
	a.  square of a number
b.  cube of a number.
Using delegate  call this method.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_1
{
    delegate void Mydelegate(int num);

    public static class Calculator
    {
        public static void square(int num)
        {
            Console.WriteLine("Square is:{0}", num * num);
        }

        public static void cube(int num)
        {
            Console.WriteLine("Cube is:{0}", num * num * num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate m1 = new Mydelegate(Calculator.square);
            Mydelegate m2 = new Mydelegate(Calculator.cube);

            m1(2);
            m2(3);

            Console.ReadLine();
        }
    }
}
