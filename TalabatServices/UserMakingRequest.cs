using Microsoft.VisualBasic.ApplicationServices;
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
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            LoadPhones();
            LoadAddress();

            
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
            FormStateMgr.SwitchToForm(this, acceptedForm, u_id.ToString(), false);

            acceptedForm.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            statusCheckTimer.Stop();
            this.Hide();
            UserHomePage homePage = new UserHomePage(u_id);
            FormStateMgr.SwitchToForm(this, homePage, u_id.ToString(), false);
            homePage.Show();
        }

        private void UserMakingRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormStateMgr.SaveCurrentForm(this.Name, u_id.ToString(), false);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string selectedDistrict = comboBox2.SelectedItem.ToString(); // Get the selected district from ComboBox

                // Connection string
                string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                // SQL query to update the old district with CurrentlySelected = 0
                string updateOldDistrictQuery = @"
            UPDATE User_Phones
            SET CurrentlySelected = 0
            WHERE U_ID = @WorkerID AND CurrentlySelected = 1";

                // SQL query to update the selected district with CurrentlySelected = 1
                string updateNewDistrictQuery = @"
            UPDATE User_Phones
            SET CurrentlySelected = 1
            WHERE U_ID = @WorkerID AND Phone = @Phone";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;

                            // First, update the old district
                            cmd.CommandText = updateOldDistrictQuery;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@WorkerID", u_id); // Replace `id` with the actual Worker ID variable
                            cmd.ExecuteNonQuery(); // Execute the update for the old district

                            // Second, update the new selected district
                            cmd.CommandText = updateNewDistrictQuery;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@WorkerID", u_id); // Replace `id` with the actual Worker ID variable
                            cmd.Parameters.AddWithValue("@Phone", selectedDistrict); // Use the selected district
                            cmd.ExecuteNonQuery(); // Execute the update for the new selected district
                        }

                        // Optionally, display a message or update the UI to reflect the change
                        MessageBox.Show($"Phone changed to {selectedDistrict}.");
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void AddressBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAddress = AddressBox.SelectedItem.ToString();

            string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Split the selected address into individual components (assuming space is the separator)
            string[] addressParts = selectedAddress.Split(' ');

            if (addressParts.Length == 5)
            {
                string district = addressParts[0];
                string streetName = addressParts[1];
                string buildingNo = addressParts[2];
                string apartmentNo = addressParts[3];
                string floorNo = addressParts[4];

                string updateOldDistrictQuery = @"
            UPDATE User_Addresses
            SET CurrentlySelected = 0
            WHERE U_ID = @WorkerID AND CurrentlySelected = 1";

                // SQL query to update the selected district with CurrentlySelected = 1
                string updateNewDistrictQuery = @"
            UPDATE User_Addresses
            SET CurrentlySelected = 1
            WHERE U_ID = @WorkerID AND Street_Name = @StreetName
                                                      AND Building_No = @BuildingNo
                                                        AND Apartment_No = @ApartmentNo
                                                          AND District = @District";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;

                            // First, update the old district
                            cmd.CommandText = updateOldDistrictQuery;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@WorkerID", u_id); // Replace `id` with the actual Worker ID variable
                            cmd.ExecuteNonQuery(); // Execute the update for the old district

                            // Second, update the new selected district
                            cmd.CommandText = updateNewDistrictQuery;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@WorkerID", u_id); // Replace `id` with the actual Worker ID variable
                            cmd.Parameters.AddWithValue("@StreetName", streetName);
                            cmd.Parameters.AddWithValue("@BuildingNo", buildingNo);
                            cmd.Parameters.AddWithValue("@ApartmentNo", apartmentNo);
                            cmd.Parameters.AddWithValue("@District", district); // Use the selected district
                            cmd.ExecuteNonQuery(); // Execute the update for the new selected district
                        }

                        // Optionally, display a message or update the UI to reflect the change
                        MessageBox.Show($"Address changed.");
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid address format.");
            }
        }

        private void LoadPhones()
        {
            try
            {
                string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Phone FROM User_Phones WHERE U_ID = @WorkerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@WorkerID", u_id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox2.Items.Add(reader["Phone"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Phones: {ex.Message}");
            }
        }

        private void LoadAddress()
        {
            string query = @"SELECT CONCAT(District, ' ', Street_Name, ' ', Building_No, ' ', Apartment_No, ' ', Floor_No) AS FullAddress
             FROM User_Addresses
             WHERE U_ID = @UserId";

            string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", u_id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    AddressBox.Items.Clear();
                    while (reader.Read())
                    {
                        // Add the concatenated address to the ComboBox
                        AddressBox.Items.Add(reader["FullAddress"].ToString());
                    }
                }
            }
        }
    }
}
