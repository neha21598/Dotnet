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

                    SqlDataReader rdr = cmd.ExecuteReader();

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

        public Student Display_details(int id)
        {
            using (SqlConnection con = getConnection())
            {
                Student s = new Student();

                SqlCommand cmd = new SqlCommand("select * from Student where Id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    s.Name = rdr["Name"].ToString();
                    s.Address = rdr["Address"].ToString();
                    break;
                }

                return s;
            }
        }

        public void Update(Student s)
        {
            int Totalrows = 0;

            using (SqlConnection con = getConnection())
            {
                SqlCommand cmd = new SqlCommand("update Student set Name=@sname,Address=@saddress where id=@id", con);
                cmd.Parameters.AddWithValue("@sname", s.Name);
                cmd.Parameters.AddWithValue("@saddress", s.Address);
                cmd.Parameters.AddWithValue("@id", s.id);


                con.Open();

                Totalrows = cmd.ExecuteNonQuery();

            }
        }

        public void Delete(int id)
        {
            using (SqlConnection con = getConnection())
            {
                SqlCommand cmd = new SqlCommand("delete from student where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();

                cmd.ExecuteNonQuery();

            }
        }
    }
}