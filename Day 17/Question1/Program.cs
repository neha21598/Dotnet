/*Q1. Create table Emp having column Id, Name, Salary.using ADO.Net display all detail of the table.
Do not forget to add record in table.

 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day17_1
{
    class Demo
    {
        public void employee()
        {
            string connectionstring =@"Data Source=(localdb)\Projects;Initial Catalog=Emp_db;Integrated Security=True";


            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("select * from Employee", con);
                con.Open();
                SqlDataReader rdr= cmd.ExecuteReader();

                if(rdr.HasRows)
                {
                    while(rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2}",rdr["Id"],rdr["Name"],rdr["Salary"]);
                    }
                }
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.employee();
            Console.ReadLine();
        }
    }
}

/* OUTPUT
1 Neha 50000
2 Pallavi 30000
3 Pooja 70000

*/