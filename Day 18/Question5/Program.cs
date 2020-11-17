/* Q4. Create a table product having column Id, Name ,Qty, price. Using like query display all product starting from letter ‘t’.
 * try SQL Injection.
Q5. Solve above SQL Injection problem with parameterised query.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day18_5
{
    class Product
    {
        public void productdetails(string pname)
        {
            string connectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=Product_db;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                string command = "select * from product where Name like @pname ";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.Parameters.AddWithValue("@pname", pname + "%");
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3} ", rdr["Id"], rdr["Name"], rdr["Qty"],rdr["Price"]);
                    }
                }


            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            string s="A";

            p.productdetails(s);
            Console.ReadLine();
        }
    }
}
