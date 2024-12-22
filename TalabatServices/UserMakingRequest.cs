using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TalabatServices
{
    public partial class UserMakingRequest : Form
    {
        private int u_id;
        private int lastRequestId;
        private System.Windows.Forms.Timer statusCheckTimer;
        private bool isCheckingStatus = false;

        public string constring = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public UserMakingRequest(int U_ID)
        {
            InitializeComponent();
            u_id = U_ID;
        }

        private void UserMakingRequest_Load(object sender, EventArgs e)
        {
            // Initialize timer for status checking
            statusCheckTimer = new System.Windows.Forms.Timer
            {
                Interval = 5000 // Check every 5 seconds
            };
            statusCheckTimer.Tick += StatusCheckTimer_Tick;

            // Load available services into the combo box
            LoadServiceNames();
        }

        private void LoadServiceNames()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();
                    string query = "SELECT Name FROM Services";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                chooseservice.Items.Add(reader["Name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading service names: {ex.Message}");
            }
        }

        private int GetServiceIdByName(string serviceName)
        {
            using (SqlConnection connection = new SqlConnection(constring))
            {
                connection.Open();
                string query = "SELECT S_ID FROM Services WHERE Name = @ServiceName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ServiceName", serviceName);
                    return (int)command.ExecuteScalar();
                }
            }
        }

        private void makrequest_Click(object sender, EventArgs e)
        {
            // Validate that the description is not empty
            if (string.IsNullOrWhiteSpace(description.Text))
            {
                MessageBox.Show("Please write a description before confirming the request.");
                return;
            }

            // Validate that a service is selected
            if (chooseservice.SelectedItem == null)
            {
                MessageBox.Show("Please select a service.");
                return;
            }

            // Insert the request into the database
            try
            {
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();

                    string selectedService = chooseservice.SelectedItem.ToString();
                    string descriptionText = description.Text;
                    int serviceId = GetServiceIdByName(selectedService);

                    string query = @"
                        INSERT INTO Request (U_ID, S_ID, Description, Status, Start_Date, End_Date) 
                        OUTPUT INSERTED.Req_ID
                        VALUES (@UserId, @ServiceId, @Description, 'Pending', GETDATE(), DATEADD(DAY, 7, GETDATE()))";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", u_id);
                        command.Parameters.AddWithValue("@ServiceId", serviceId);
                        command.Parameters.AddWithValue("@Description", descriptionText);

                        lastRequestId = (int)command.ExecuteScalar();
                    }

                    MessageBox.Show("Request has been successfully created.");
                    statusCheckTimer.Start(); // Start checking for status updates
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the request: {ex.Message}");
            }
        }

        private void StatusCheckTimer_Tick(object sender, EventArgs e)
        {
            if (isCheckingStatus) return; // Prevent concurrent status checks

            isCheckingStatus = true;
            try
            {
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();

                    string query = "SELECT Status FROM Request WHERE Req_ID = @RequestId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestId", lastRequestId);

                        string status = command.ExecuteScalar()?.ToString();
                        if (string.IsNullOrEmpty(status))
                        {
                            MessageBox.Show("No status found for this request.");
                            return;
                        }

                        if (status == "Accepted")
                        {
                            statusCheckTimer.Stop();
                            MessageBox.Show("Your request has been accepted!");
                            OpenUserRequestAcceptedForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking request status: {ex.Message}");
            }
            finally
            {
                isCheckingStatus = false;
            }
        }

        private void OpenUserRequestAcceptedForm()
        {
            this.Hide();
            UserRequestAccepted acceptedForm = new UserRequestAccepted(lastRequestId);
            acceptedForm.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            statusCheckTimer.Stop();
            this.Hide();
            UserHomePage homePage = new UserHomePage(u_id);
            homePage.Show();
        }
    }
}
