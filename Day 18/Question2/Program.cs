/*Q2. In the above example 
a. store employee record in database 
b. Update and delete one record 
using ExecutenonQuery() method
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day18_2
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }

    class EmployeeLayer
    {
          
        public void Employee_insert()
        {
            int Totalrows = 0;
         
                string connectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=Employee_db;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    try
                    {
                   
                        //To update the data
                       SqlCommand cmd= new SqlCommand("update Employee set Name='piyush' where Id=3",con);
                       con.Open();
                        Totalrows = cmd.ExecuteNonQuery();
                        Console.WriteLine("Total rows affected due to update query are:{0}", Totalrows.ToString());

                        //To delete the data
                        cmd.CommandText = "delete from Employee  where Id=5";
                        Totalrows = cmd.ExecuteNonQuery();
                        Console.WriteLine("Total rows affected due to delete query are:{0}", Totalrows.ToString());


                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            EmployeeLayer empl = new EmployeeLayer();
            empl.Employee_insert();

            Console.ReadLine();
           }
    }
}
