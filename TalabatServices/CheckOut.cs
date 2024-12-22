using Azure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalabatServices
{
    //FormNum5
    public partial class CheckOut : Form
    {
        private int U_ID;
        private int Requestid;
        private int Flag0User1Worker;
        public CheckOut(int Req_ID, int FlagUserWorker)
        {
            InitializeComponent();
            Requestid = Req_ID;
            Flag0User1Worker = FlagUserWorker;
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void CheckOut_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT Item_Name, Quantity, Item_Cost FROM Payment Where Req_ID = {Requestid}";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind to DataGridView
                dataGridView1.DataSource = dataTable;

                string query2 = $@"SELECT SUM(Item_Cost * Quantity) FROM Payment WHERE Req_ID = {Requestid}";
                SqlCommand command2 = new SqlCommand(query2, connection);
                connection.Open();

                var result = command2.ExecuteScalar();
                connection.Close();

                // Check if the result is not null and display in the TextBox
                if (result != DBNull.Value)
                {
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "0"; // Or handle as needed if no result is found
                }



            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userOrWorkerId = 0;

            // Define the connection string
            string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Retrieve U_ID or W_ID based on the flag
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (Flag0User1Worker == 0) // If flag is 0, retrieve U_ID
                {
                    string query = "SELECT U_ID FROM Request WHERE Req_ID = @Req_ID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Req_ID", Requestid);

                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        userOrWorkerId = Convert.ToInt32(result);
                    }
                }
                else if (Flag0User1Worker == 1) // If flag is 1, retrieve W_ID
                {
                    string query = "SELECT W_ID FROM Request WHERE Req_ID = @Req_ID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Req_ID", Requestid);

                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        userOrWorkerId = Convert.ToInt32(result);
                    }
                }

                connection.Close();
            }

            // Show the appropriate form based on the flag
            if (Flag0User1Worker == 0 && userOrWorkerId > 0) // For user
            {
                

                string connectionString1 = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Update this with your connection string
                using (SqlConnection conn1 = new SqlConnection(connectionString1))
                {
                    conn1.Open();
                    string query1 = "SELECT U_ID FROM Request WHERE Req_ID = @Req_ID";
                    using (SqlCommand cmd = new SqlCommand(query1, conn1))
                    {
                        cmd.Parameters.AddWithValue("@Req_ID", Requestid);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                U_ID = reader.GetInt32(0); 
                            }
                        }
                    }
                }


                this.Hide();
                Rating rate = new Rating(Requestid,U_ID);
                rate.Show();
            }
            else if (Flag0User1Worker == 1 && userOrWorkerId > 0) // For worker
            {
                this.Hide();
                WorkerHomePage WHP = new WorkerHomePage(userOrWorkerId);
                WHP.Show();
            }
            else
            {
                MessageBox.Show("Error: Unable to retrieve User/Worker ID.");
            }
        }
    }
}
