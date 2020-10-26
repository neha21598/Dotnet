/* Q1. Create a class Employee having member variable Firstname, Lastname, Middlename.let your application create object even if 
 * user does not enter Middlename. Create two constructor one take parameter for Firstname, Lastname and second constructor which
 * will take all the parameter. Write display method which will display detail of the object.*/

using System;

namespace Day5_1_lib
{
    public class Employee
    {
        string fname, mname, lname;

        public Employee()
        {
            Console.WriteLine("In No arg COnstructor");
        }

        public Employee(string fnm, string mnm, string lnm)
        {
            fname = fnm;
            mname = mnm;
            lname = lnm;
        }

        public Employee(string fnm, string lnm)
        {
            fname = fnm;
            lname = lnm;
        }

        public void display()
        {
            Console.WriteLine("Hello {0} {1} {2}", fname, mname, lname);
        }
    }
}
