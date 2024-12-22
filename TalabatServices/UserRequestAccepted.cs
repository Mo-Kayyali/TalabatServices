using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TalabatServices
{
    public partial class UserRequestAccepted : Form
    {
        public string constring = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private int reqId; // Store the Request ID
        private System.Windows.Forms.Timer statusCheckTimer; // Timer for status checking

        public UserRequestAccepted(int Req_ID)
        {
            InitializeComponent();
            reqId = Req_ID; // Initialize the request ID
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void UserRequestAccepted_Load(object sender, EventArgs e)
        {
            // Initialize and start the timer
            statusCheckTimer = new System.Windows.Forms.Timer();
            statusCheckTimer.Interval = 5000; // 5 seconds
            statusCheckTimer.Tick += StatusCheckTimer_Tick;
            statusCheckTimer.Start();

            LoadWorkerDetails();
        }

        private void LoadWorkerDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();

                    string query = @"
                        SELECT w.Name, wp.Phone, w.Rate
                        FROM dbo.Workers w ,dbo.Worker_Phones wp  
                        WHERE w.W_ID = wp.W_ID and wp.CurrentlySelected = 1 and  w.W_ID = (
                            SELECT W_ID
                            FROM dbo.Request
                            WHERE Req_ID = @RequestId )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestId", reqId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                name.Text = reader["Name"].ToString();
                                phone.Text = reader["Phone"].ToString();
                                rating.Text = reader["Rate"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Failed to load worker details.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failure: {ex.Message}");
            }
        }

        private void StatusCheckTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();

                    string query = "SELECT Status FROM dbo.Request WHERE Req_ID = @RequestId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestId", reqId);

                        string status = command.ExecuteScalar()?.ToString();

                        if (status == "Finished")
                        {
                            // Stop the timer
                            statusCheckTimer.Stop();

                            // Close the current form
                            this.Close();

                            // Open the Checkout form
                            CheckOut checkoutForm = new CheckOut(reqId,0);
                            checkoutForm.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking request status: {ex.Message}");
            }
        }


    }
}
