/* Q3. Create a class customer having member Id, name,
 billamount. When you create a object allow to have 
default vale. Print default value of id,name, 
billamount.*/

using System;
using Day_4_3_lib;

namespace Day4_3_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.display();
        }
    }
}
