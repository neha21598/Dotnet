/*Using model first approach generate database,  and classes .[complete emp dept task] perform insert, delete, update*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Model_secondContainer ms = new Model_secondContainer();
            var result= ms.Employee1.ToList();
            foreach (var a in result)
            {
                Console.WriteLine("{0} {1} ", a.Name, a.Salary);

            }

           
            Insert();
            Update(3);
            Delete(3);
            Console.ReadLine();
        }

        static void Insert()
        {
            Model_secondContainer ms = new Model_secondContainer();
            Employee1 e1 = new Employee1();
            e1.Name = "Tejal";
            e1.Salary = 30000;
            ms.Employee1.Add(e1);
            ms.SaveChanges();
        }

        static void Update(int id)
        {
            Model_secondContainer ms = new Model_secondContainer();
            Employee1 e1 = new Employee1();

            Employee1 em= ms.Employee1.Find(id);
            em.Name = "Prashant";

            ms.SaveChanges();

        }

        static void Delete(int id)
        {
            Model_secondContainer ms = new Model_secondContainer();
            Employee1 e1 = new Employee1();

            Employee1 em = ms.Employee1.Find(id);
            ms.Employee1.Remove(em);


            ms.SaveChanges();

        }
    }
}
