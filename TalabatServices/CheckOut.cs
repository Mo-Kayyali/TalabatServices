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
    public partial class CheckOut : Form
    {
        private int Requestid;
        public CheckOut(int requestid)
        {
            InitializeComponent();
            Requestid = requestid;
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

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
