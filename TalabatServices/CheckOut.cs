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
        public CheckOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            //LoadData();
        }
        
        //private void LoadData()
        //{
        //    string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = "SELECT Name, Quantity, Price FROM Items";
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //        DataTable dataTable = new DataTable();
        //        adapter.Fill(dataTable);

        //        // Bind to DataGridView
        //        dataGridView1.DataSource = dataTable;
        //    }
        //}
        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
