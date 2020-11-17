/* Q1. Create a table Employee having column  Id, Name, Salary.
 * Create a class Employee having member Id, Name, Salary. Create a class BusinessLayer with a getter method
 *who’s job is to return list of the employee retrieved from database and map to the class Employee.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Day18_1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

    }
    
    public class EmployeeLayer
    {
        public List<Employee> mylist
        {
            get
            {

                string connectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=Employee_db;Integrated Security=True";

                List<Employee> mylist = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionstring))
                {

                    SqlCommand cmd = new SqlCommand("select * from Employee", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Employee emp = new Employee();
                        emp.Id = Convert.ToInt32(rdr["Id"]);
                        emp.Name = rdr["Name"].ToString();
                        emp.Salary = Convert.ToSingle(rdr["Salary"]);

                        mylist.Add(emp);

                    }
                    return mylist;
              
                }

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
                EmployeeLayer el = new EmployeeLayer();
                
                foreach (Employee e in el.mylist)
                {
                    Console.WriteLine("{0} {1} {2} ", e.Id, e.Name, e.Salary);
                }
            Console.ReadLine();
        }
    }
}
