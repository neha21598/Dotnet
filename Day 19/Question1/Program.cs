/*Q1. Create a table Employee having column  Id, Name, Salary. Create a class Employee having member Id, Name, Salary.
 * Create a class BusinessLayer  and write two method 
Public Employee search(int id)
Public List<Employee>(string name)
Above method will search the record and return results. Entry point class will display data.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day19_1
{
    class Employee
    {
       public  int Id { get; set; }
       public  string Name { get; set; }
       public  float Salary { get; set; }

    }

    class Employee_details
    {
        //common connection function
        public SqlConnection getConnection()
        {
            string connectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=Employee_db;Integrated Security=True";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionstring;
            return con;
        }

        //To search the data by given Id
        public Employee  Search(int id)
        {
            SqlConnection con = null;
            SqlCommand cmd;
            Employee emp = null;

            con = getConnection();
            con.Open();
            cmd = new SqlCommand("select * from Employee where Id=@pid", con);
            cmd.Parameters.AddWithValue("@pid", id);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                     emp = new Employee();
                    emp.Id = Convert.ToInt32(rdr["Id"]);
                    emp.Name = rdr["Name"].ToString();
                    emp.Salary = Convert.ToSingle(rdr["Salary"]);
                    break;
                }
               
            }
            return emp;
                
           
        }

        //To search the data by name
        public List<Employee> Search(string name)
        {
            SqlConnection con = null;
            SqlCommand cmd;
            List<Employee> l = null;

            con = getConnection();
            con.Open();
            cmd = new SqlCommand("select * from Employee where Name=@pname", con);
            cmd.Parameters.AddWithValue("@pname", name);
            SqlDataReader rdr= cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                l = new List<Employee>();

                while (rdr.Read())
                {
                    Employee e = new Employee();
                    e.Id = Convert.ToInt32(rdr["Id"]);
                    e.Name = rdr["Name"].ToString();
                    e.Salary = Convert.ToSingle(rdr["Salary"]);

                    l.Add(e);
                }
            }
            return l;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee_details empd = new Employee_details();
            Employee e=empd.Search(1);
            Console.WriteLine("Data with Id 1 is:\n");

            Console.WriteLine("Id    Name    Salary");
            Console.WriteLine("{0}    {1}    {2}", e.Id, e.Name, e.Salary);

            Console.WriteLine("****************************************");
             
            List<Employee> mylist= empd.Search("Pallavi");
            Console.WriteLine("Data with Name Pallavi is:\n");
            Console.WriteLine("Id    Name    Salary");
            
            foreach(Employee el in mylist)
            {
                Console.WriteLine("{0}    {1}    {2} ",el.Id,el.Name,el.Salary);

            }
            Console.ReadLine();
        }
    }
}

/*OUTPUT
Data with Id 1 is:

Id    Name    Salary
1    Neha    50000
****************************************
Data with Name Pallavi is:

Id    Name    Salary
2    Pallavi    30000

*/