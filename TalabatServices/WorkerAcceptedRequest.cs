using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace TalabatServices
{
    public partial class WorkerAcceptedRequest : Form
    {
        private int RequestID;
        private int UserID;
        private int WorkerID;
        private int ServiceID;

        public WorkerAcceptedRequest(int reqID)
        {
            InitializeComponent();
            RequestID = reqID;
            LoadUserData(reqID);
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoadUserData(int reqID)
        {
            try
            {
                
                string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string query = @"
                        SELECT 
                        u.Name AS UserName, 
                        p.Phone AS UserPhone,
                        s.Name AS ServiceName, 
                        CONCAT(a.Street_Name,  a.Building_No,  a.Apartment_No) AS Address,
                        r.Description, 
                        r.U_ID, 
                        r.W_ID, 
                        r.S_ID
                    FROM Request r
                    INNER JOIN Users u ON r.U_ID = u.U_ID
                    LEFT JOIN User_Phones p ON u.U_ID = p.U_ID AND p.CurrentlySelected = 1
                    LEFT JOIN User_Addresses a ON u.U_ID = a.U_ID AND a.CurrentlySelected = 1
                    INNER JOIN Services s ON r.S_ID = s.S_ID
                    WHERE r.Req_ID = @ReqID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReqID", reqID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate form fields
                                Name_tb.Text = reader["UserName"].ToString();
                                Phone_tb.Text = reader["UserPhone"]?.ToString(); 
                                Service_tb.Text = reader["ServiceName"].ToString();
                                Addr_tb.Text = reader["Address"]?.ToString(); 
                                Description_tb.Text = reader["Description"].ToString();

                                // Store IDs for later use
                                UserID = Convert.ToInt32(reader["U_ID"]);
                                WorkerID = Convert.ToInt32(reader["W_ID"]);
                                ServiceID = Convert.ToInt32(reader["S_ID"]);
                            }
                            else
                            {
                                MessageBox.Show("No data found for the provided Request ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddingItemsToCart AITC = new AddingItemsToCart(RequestID);
            AITC.Show();
        }
    }
}
