/* Create a class employee having member name and salary, it has reference of address class which display location name[eg. vile-parle]
 * Create a duplicate object using clone method.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_4
{
    public class Employee:ICloneable
    {
        String name;
        double salary;
      public   Address add = new Address();


        public Employee(string name,double salary ,string location)
        {
            this.name = name;
            this.salary = salary;
            add.location = location;
        }

       
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return String.Format("Name={0} Salary={1} Address={2}", name, salary,add.location);
        }
    }

     public  class Address
    {
       public  string location;

       public  Address()
        {
            location = "Nooname";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Neha",50000,"Nasik");
            Employee e2 = (Employee)e1.Clone();

            Console.WriteLine(e1);
            Console.WriteLine("After Cloning:");
            Console.WriteLine(e2);

            Console.ReadLine();
        }
    }
}
