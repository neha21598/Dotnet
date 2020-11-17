/* Q4. Create a table product having column Id, Name ,Qty, price. Using like query display all product starting from letter ‘t’.
 * try SQL Injection.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day18_4
{
    public class Productdetail
    {
        public void Product(string pname)
        {
            string connectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=Product_db;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {  
                    SqlCommand cmd = new SqlCommand("Select * from Product where Name like '" + pname + "%'", connection);
                    connection.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                        Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Price"], rd["Qty"]);
                }

                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Productdetail pd = new Productdetail();
            string s = "A";

            //sql injection
            //string s = "A';delete from Product;Select * from Product where Name like 'A";
                
            pd.Product(s);
            Console.ReadLine();

        }
    }
}
