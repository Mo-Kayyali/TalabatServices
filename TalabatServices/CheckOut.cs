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
        private int Requestid;
        public CheckOut(int Req_ID)
        {
            InitializeComponent();
            Requestid = Req_ID;
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
