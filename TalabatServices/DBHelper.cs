using System;
using System.Data.SqlClient;

namespace TalabatServices
{
    internal static class DBHelper
    {
        public static void SaveFormState(string userId, bool isWorker, string formName)
        {
            string tableName = isWorker ? "Workers" : "Users";
            string idColumn = isWorker ? "W_ID" : "U_ID"; // Dynamically set the ID column based on user/worker
            string query = $"UPDATE {tableName} SET Form_Num = @formName WHERE {idColumn} = @userId";

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
            string idColumn = isWorker ? "W_ID" : "U_ID"; // Dynamically set the ID column based on user/worker
            string query = $"SELECT Form_Num FROM {tableName} WHERE {idColumn} = @userId";

            using (SqlConnection connection = new SqlConnection(@"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
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
