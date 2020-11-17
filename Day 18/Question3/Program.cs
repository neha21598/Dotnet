/* Q3. Use aggregate function ie.  count number of employee in database*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day18_3
{
    public class Employee
    {
        public int Employee_count
        {
           
            
            get
            {
                string ConnectionString = @"Data Source=(localdb)\Projects;Initial Catalog=Employee_db;Integrated Security=True";
                int TotalRows = 0;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Select Count(Id) from Employee", connection);
                        connection.Open();
                        TotalRows = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                return TotalRows;

            }  
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            int x=emp.Employee_count;
            Console.WriteLine("Total number of rows are:{0}", x);
            Console.ReadLine();
        }
    }
}
