using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CreateStudent
    {
        static void Main(string[] args)
        {
            CreateTable();
        }
        public static void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=DESKTOP-KUEO82L\\LAXMAN;Initial Catalog=Laxman;Integrated Security=True");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table Employees(EmpID int not null, FullName varchar(100), MangaerID int not null, join_date date)", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
