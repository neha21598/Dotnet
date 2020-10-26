/* Q2. Create a class Employee having private instance member Id, Name Salary, netsalary. Create method calculate_netsalary who’s
 * job is to deduct 10% of TDS.. Write method display which will display name and netsalary. This application will be classlibrary.
Create console application and use this class library. Create at least two object of Employee class */

using System;

namespace Day4_2_lib
{
    public class Employee
    {
        string name;
        int id;
        static int getid;
        double salary,netsalary;
        public readonly double TDS=0.1;

        public Employee(string name, double salary)
        {
            id=++getid;
            this.name = name;
            this.salary = salary;
            Console.WriteLine("Hiii {0}.{1}",id,this.name );
            Console.WriteLine("Your current Salary is:" + this.salary);
        }

        static Employee()
        {
            Console.WriteLine("******************WELCOME TO YOUR BANK APPLICATION ********************** ");
        }

        public void calculate_net()
        {
            netsalary = salary - salary * TDS;
            Console.WriteLine("Netsalary is:{0}", netsalary);
        }

        
        public void display()
        {
            Console.WriteLine("{0}{1}{2}", id,name, netsalary);
        }

    }
}
