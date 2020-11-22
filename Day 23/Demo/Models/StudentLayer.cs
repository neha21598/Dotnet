using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Day23_Demo.Models
{
    public class StudentLayer
    {
        public SqlConnection getConnection()
        {
            string connectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=Student_Db;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionstring;
            return con;
        }

        public void InsertData(Student s)
        {
            int Totalrows = 0;

            using (SqlConnection con = getConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into Student values(@sname,@saddress)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@sname", s.Name);
                cmd.Parameters.AddWithValue("@saddress", s.Address);

                Totalrows = cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted Successfully");
            }
        }

        public List<Student> Display
        {
            get
            {
                List<Student> mylist = new List<Student>();

                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = new SqlCommand("Select * from Student", con);
                    con.Open();

                   SqlDataReader rdr= cmd.ExecuteReader();

                   if (rdr.HasRows)
                   {
                       while (rdr.Read())
                       {
                           Student s = new Student();
                          
                           s.Name = rdr["Name"].ToString();
                           s.Address = rdr["Address"].ToString();

                           mylist.Add(s);

                       }
                   }
                   return mylist;
                }
            }
        }
    }
}