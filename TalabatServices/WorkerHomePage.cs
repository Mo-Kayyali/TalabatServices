﻿using System;
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
    public partial class WorkerHomePage : Form
    {
        private int WorkerID; // Worker ID to identify the logged-in worker
        private System.Windows.Forms.Timer ordersRefreshTimer;

        public WorkerHomePage(int workerID)
        {
            InitializeComponent();

            WorkerID = workerID;


            ordersRefreshTimer = new System.Windows.Forms.Timer();
            ordersRefreshTimer.Interval = 5000; // Refresh every 30 seconds
            ordersRefreshTimer.Tick += OrdersRefreshTimer_Tick;
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void WorkerHomePage_Load(object sender, EventArgs e)
        {
            LoadWorkerInfo();
            LoadDistricts();

            // Start the timer
            ordersRefreshTimer.Start();
        }

        private void OrdersRefreshTimer_Tick(object sender, EventArgs e)
        {
            if (District_cb.SelectedItem != null)
            {
                LoadOrders(District_cb.SelectedItem.ToString());
            }
        }

        private void LoadWorkerInfo()
        {
            try
            {
                string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT Name, Rate 
                        FROM Workers 
                        WHERE W_ID = @WorkerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@WorkerID", WorkerID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string workerName = reader["Name"] == DBNull.Value ? "N/A" : reader["Name"].ToString();
                                string workerRate = reader["Rate"] == DBNull.Value ? "N/A" : reader["Rate"].ToString();

                                WorkerName_lbl.Text = workerName;
                                WorkerRating_lbl.Text = $"Rating: {workerRate}";
                            }
                            else
                            {
                                MessageBox.Show("No worker found with the given ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading worker info: {ex.Message}");
            }
        }

        private void LoadDistricts()
        {
            try
            {
                string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT District FROM Worker_Districts WHERE W_ID = @WorkerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@WorkerID", WorkerID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                District_cb.Items.Add(reader["District"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading districts: {ex.Message}");
            }
        }

        private void District_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders(District_cb.SelectedItem.ToString());
        }

        private void LoadOrders(string district)
        {
            try
            {
                string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT R.Req_ID, R.Description, R.Start_Date, R.Status
                        FROM Request R, User_Addresses UA
                        WHERE UA.District = @District AND UA.CurrentlySelected = 1 and UA.U_Id = R.U_ID And R.Status = 'Pending'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@District", district);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable ordersTable = new DataTable();
                            adapter.Fill(ordersTable);

                            dataGridView_Orders.DataSource = ordersTable;
                            AddAcceptButtonColumn();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}");
            }
        }

        private void AddAcceptButtonColumn()
        {
            if (!dataGridView_Orders.Columns.Contains("Accept"))
            {
                DataGridViewButtonColumn acceptColumn = new DataGridViewButtonColumn
                {
                    Name = "Accept",
                    HeaderText = "Accept Order",
                    Text = "✔",
                    UseColumnTextForButtonValue = true
                };
                dataGridView_Orders.Columns.Add(acceptColumn);
            }
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_Orders.Columns["Accept"].Index)
            {
                int selectedOrderId = Convert.ToInt32(dataGridView_Orders.Rows[e.RowIndex].Cells["Req_ID"].Value);

                try
                {
                    string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Request SET Status = 'Accepted', W_ID = @WorkerID WHERE Req_ID = @OrderID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@WorkerID", WorkerID);
                            command.Parameters.AddWithValue("@OrderID", selectedOrderId);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Order accepted successfully!");

                            this.Hide();
                            WorkerAcceptedRequest WAR = new WorkerAcceptedRequest(selectedOrderId);
                            WAR.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error accepting order: {ex.Message}");
                }
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileSettings PS = new ProfileSettings(WorkerID, 1);
            PS.Show();
        }

    }
}
