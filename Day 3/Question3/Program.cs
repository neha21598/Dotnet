/* Q3. Create struct emp having member name and salary, using constructor initialized member.
 * Write display method which will display name and salary*/

using System;

namespace Day_3_3
{
   struct emp
   {
       string name;
       double salary;

       public emp(string name, double salary)
       {
           this.name = name;
           this.salary = salary;
       }

       public void display()
       {
           Console.WriteLine("Hiii {0} your Salary is:{1}", name, salary);
       }
        
       static void Main(string[] args)
       {
           emp e1 = new emp("Neha", 50000);
           e1.display();
           Console.ReadLine();
       }
    }
}
