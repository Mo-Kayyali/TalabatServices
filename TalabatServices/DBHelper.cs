using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalabatServices
{
    internal static class DBHelper
    {
        public static void SaveFormState(string userId, bool isWorker, string formName)
        {
            // Update the "Form_Num" column in the database for the logged-in user/worker
            string tableName = isWorker ? "Workers" : "Users";
            string query = $"UPDATE {tableName} SET Form_Num = @formName WHERE ID = @userId";

            // Execute the query (use a parameterized query to avoid SQL injection)
            using (SqlConnection connection = new SqlConnection(@"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@formName", formName);
                command.Parameters.AddWithValue("@userId", userId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static string GetLastFormState(string userId, bool isWorker)
        {
            string tableName = isWorker ? "Workers" : "Users";
            string query = $"SELECT Form_Num FROM {tableName} WHERE ID = @userId";

            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                connection.Open();
                var result = command.ExecuteScalar();
                return result != null ? result.ToString() : "DefaultForm"; // Default form fallback
            }
        }
    }

}
