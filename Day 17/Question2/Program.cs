/*
 * Create table Emp having column Id, Name, Salary.using ADO.Net display all detail of the table.
Do not forget to add record in table.
 Solve above program using setter method connection string in SqlConnection class.


 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day17_2
{
    class Demo
    {
        public void Emp()
        {
        string connectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=Employee_db;Integrated Security=True";

        using(SqlConnection connection=new SqlConnection())
        {
            connection.ConnectionString = connectionstring;
            SqlCommand cmd = new SqlCommand("select * from Employee", connection);
            connection.Open();
           SqlDataReader rdr= cmd.ExecuteReader();
           if (rdr.HasRows)
           {
               while (rdr.Read())
               {
                   Console.WriteLine("{0} {1} {2}", rdr["Id"], rdr["Name"], rdr["Salary"]);
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
            d.Emp();
            Console.ReadLine();
        }
    }
}
