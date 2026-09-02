using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_6
{
     class TestConnectWithDatabase
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Server=DESKTOP-LRMPGLQ;DataBase=TestConnect;User Id=sa;Password=123";
            string query = "INSERT INTO Students VALUES( 'Omar', 95)";

            using ( SqlConnection conn = new SqlConnection(ConnectionString)) 
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
 

                //SqlDataReader reder = cmd.ExecuteReader();

                //while (reder.Read())
                //{
                //    int    id    = Convert.ToInt32(reder["Id"]);
                //    string name  = Convert.ToString(reder["Name"]);
                //    double Grade = Convert.ToDouble(reder["Grade"]);

                //    //Console.WriteLine($"ID is {reder["Id"]},\n Student Name IS {reder["FullName"]} \n Student Grade is {reder["Grade"]} ");
                //      Console.WriteLine($"ID is {id},\n Student Name IS {name}} \n Student Grade is {Grade} ");
                //}
                //reder.Close();
                conn.Close();
            }

        }
    }
}
