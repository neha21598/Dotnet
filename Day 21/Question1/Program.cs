using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee_dbEntities empdb = new Employee_dbEntities();
            var result=empdb.Employees.ToList<Employee>();

            foreach (var x in result)
                Console.WriteLine("{0}  {1}  {2}  ", x.Id, x.Name, x.Salary);

         //   Insert();
            Update(2002);
            Delete(2002);
            Console.ReadLine();

        }

        static void Insert()
        {
            Employee_dbEntities empdb = new Employee_dbEntities();
            Employee e = new Employee();
            e.Name = "Prashant";
            e.Salary = 70000;
            empdb.Employees.Add(e);
            empdb.SaveChanges();

        }

        static void Update(int id)
        {
            Employee_dbEntities empdb = new Employee_dbEntities();
            Employee e = new Employee();

            Employee emp= empdb.Employees.Find(id);
            emp.Name = "Piyu";
            
            empdb.SaveChanges();

        }

        static void Delete(int id)
        {
            Employee_dbEntities empdb = new Employee_dbEntities();
            Employee e = new Employee();

            Employee emp = empdb.Employees.Find(id);
             empdb.Employees.Remove(emp);

            empdb.SaveChanges();

        }

    }
}

/* OUTPUT
1  Neha  50000
2  Poonam  30000
3  piyush  70000
1002  Devendra  50000
Press any key to continue . . .
*/
