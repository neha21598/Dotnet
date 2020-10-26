using System;
using Day4_2_lib;

namespace Day4_2_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Neha", 20000);
            e1.calculate_net();

            Console.WriteLine("\n");

            Employee e2 = new Employee("Pallavi", 10000);
            e2.calculate_net();

            Console.ReadLine();
        }
    }
}
