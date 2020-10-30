/* create a class demomaths having method Square , cube 
which will take float value and return 
square and cube of a number.*/

using System;

namespace Day1_4
{
    class demoMaths
    {
        

        public float square(float num1)
        {
            return num1 * num1;

            
        }

        public float cube(float num1)
        {
            return num1 * num1 * num1;

        }
        static void Main(string[] args)
        {

            float num1 = 1.2f;
            demoMaths dm = new demoMaths();

            float sqr = dm.square(num1);
            float cu = dm.cube(num1);

            Console.WriteLine("Sqaure is:{0}", sqr);
            Console.WriteLine("Sqaure is:{0}", cu);

            Console.ReadLine();
        }
    }
}
