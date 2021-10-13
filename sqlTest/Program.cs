using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace sqlTest {
    class Program {
        static void Main(string[] args) {

            string connetionString = "Data Source=PSE51\\SQLEXPRESS; Initial Catalog = University; Integrated Security=SSPI;";

            SqlConnection conn = new SqlConnection(connetionString);
            string query = "SELECT * FROM Student";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            conn.Open();

            Console.ReadKey();
        }
    }
}
