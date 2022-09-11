using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hakan.ConsoleApp.AdoNeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = @"Server=HAKKO;Database=NORTHWND;Integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionstring);
            //connection string xml (csv)  file olarak girdi veriyor
            con.Open();
            SqlCommand insertcmd = new SqlCommand("insert into Employees(FirstName, LastName) values ('Hakan','Yıldız')",con);
            if (insertcmd.ExecuteNonQuery()>0)
            {
                Console.WriteLine("Successfully added rows\n"+
                    "---------------");
            }
            SqlCommand selectcmd = new SqlCommand("select * from Employees", con);
            SqlDataReader reader = selectcmd.ExecuteReader();
            List<Employees> emp = new List<Employees>();
            while (reader.Read())
            {
                Employees employees = new Employees()
                {
                    EmployeeID = Convert.ToInt32(reader[nameof(Employees.EmployeeID)]),
                    FirstName = reader[nameof(Employees.FirstName)].ToString(),
                    LastName = reader[nameof(Employees.LastName)].ToString(),
                };
                emp.Add(employees);
            }
            con.Close();
            foreach (var item in emp)
            {
                Console.WriteLine(item.EmployeeID + "-" + item.FirstName + "-" + item.LastName);
            }
            Console.ReadLine(); 

        }
    }
}
