/* Q4. Create a class Printer with a private constructor. 
Your application should give only one reference of the printer object.*/

using System;

namespace Day4_4_lib
{
    public class Printer
    {
        static Printer obj;
        static Printer()
        {
            Console.WriteLine("WELCOME");
        }

        private Printer()
        {
            obj = null;
        }

        public static Printer demo()
        {
            if (obj == null)
                obj = new Printer();
            return obj;
        }

        public void display()
        {
            Console.WriteLine("HIII");
        }
    }
}
