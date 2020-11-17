/*Q3. Display all employee record using disconnected architecture.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Day19_3
{
    class Employee
    {
        public void Employee_details()
        {
                string connectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=Employee_db;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionstring);
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Employee", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds);
                Console.WriteLine(ds.GetXml());

                ds.Tables[0].TableName = "Employee";
                DataTable dt= ds.Tables["Employee"];

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.WriteLine(row[col]);
                    }
                }

                
        }
    }
class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Employee_details();
            Console.ReadLine();
        }
    }
}

/* OUTPUT
<NewDataSet>
  <Table>
    <Id>1</Id>
    <Name>Neha</Name>
    <Salary>50000</Salary>
  </Table>
  <Table>
    <Id>2</Id>
    <Name>Poonam</Name>
    <Salary>30000</Salary>
  </Table>
  <Table>
    <Id>3</Id>
    <Name>piyush</Name>
    <Salary>70000</Salary>
  </Table>
</NewDataSet>
1
Neha
50000
2
Poonam
30000
3
piyush
70000



*/