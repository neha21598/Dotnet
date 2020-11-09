/* Create array of anonymous object displaying name and salary. Print all detail*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_3
{
    public class Employee
    {
   
        string Name{get;set;}
        double Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var emp=new[] {new{Name="Neha",Salary=50000},new {Name="Pallavi",Salary=40000}};
           
            foreach (var e in emp)
            {
                Console.WriteLine("Name and Salary is:{0}   {1}",e.Name,e.Salary);
               
              

            }
         
            Console.ReadLine();
        }
    }
}
