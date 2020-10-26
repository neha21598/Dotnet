using System;
using Day5_1_lib;

namespace Day5_1_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ob =new Employee();
            Employee ob1 = new Employee("Neha","Patil");
            Employee ob2 = new Employee("Neha","Rajendra", "Patil");

            ob.display();
            ob1.display();
            ob2.display();

            Console.ReadLine();
            



        }
    }
}
