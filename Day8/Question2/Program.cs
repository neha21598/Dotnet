/* Q2. Create a class  having two method 
	1. 1. public int sqr(int n) :this method return square of a number
	2. public double cube(int s): this method return cube of a number
Compile code and observed message given by compiler.*/

using System;

namespace Day8_2
{
     class Mymath
    {
        public  int sqr(int n)
        {
            return n * n;
        }
        public  double sqr(int s)
        {
            return s * s * s;

        }

        static void Main(string[] args)
        {
            Mymath m = new Mymath();

            int res1 = m.sqr(2);
            Console.WriteLine("Square of 2 is:{0}", res1);

            double res2 = sqr(2);
            Console.WriteLine("Square of 2.2 is:{0}", res2);

            Console.ReadLine();
        }
    }
}

/* Error
Error	1	The call is ambiguous between the following methods or properties: 'Day8_2.Mymath.sqr(int)' and 'Day8_2.Mymath.sqr(int)'	c:\users\win 10\documents\visual studio 2012\Projects\Day8_2\Day8_2\Program.cs	26	24	Day8_2

*/