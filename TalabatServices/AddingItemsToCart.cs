﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TalabatServices
{
    public partial class AddingItemsToCart : Form
    {
        private int CurrentUserID;
        private int WorkerID;
        private int ServiceID;
        private int RequestID;

        // Constructor now only takes RequestID
        public AddingItemsToCart(int requestid)
        {
            InitializeComponent();
            RequestID = requestid;
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }


        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Method to fetch UserID, WorkerID, and ServiceID based on RequestID
        private void FetchRequestDetails()
        {
            try
            {
                string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT U_ID, W_ID, S_ID FROM Request WHERE Req_ID = @Req_ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Req_ID", RequestID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CurrentUserID = Convert.ToInt32(reader["U_ID"]);
                                WorkerID = Convert.ToInt32(reader["W_ID"]);
                                ServiceID = Convert.ToInt32(reader["S_ID"]);
                            }
                            else
                            {
                                MessageBox.Show("Request ID not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching request details: {ex.Message}");
            }
        }

        private void AddingItemsToCart_Load(object sender, EventArgs e)
        {
            // Fetch the request details from the database
            FetchRequestDetails();

            dataGridView1.Columns.Add("ItemName", "ItemName");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Price", "Price");

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Action";
            deleteButtonColumn.Text = "X";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);
        }

        private void AddToGrid_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ItemName_tb.Text) && !string.IsNullOrEmpty(Quantity_tb.Text) && !string.IsNullOrEmpty(Price_tb.Text))
            {
                dataGridView1.Rows.Add(ItemName_tb.Text, Quantity_tb.Text, Price_tb.Text);

                ItemName_tb.Clear();
                Quantity_tb.Clear();
                Price_tb.Clear();
            }
            else
            {
                MessageBox.Show("Please fulfill all boxes!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to set the quantity to 0?", "Confirm Update", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value = 0;
                        MessageBox.Show("Item quantity set to 0.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating row: {ex.Message}");
                    }
                }
            }
        }

        private void SubmitToDB_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string insertQuery = @"
                                INSERT INTO Payment (U_ID, W_ID, S_ID, Req_ID, Item_Name, Quantity, Item_Cost) 
                                VALUES (@U_ID, @W_ID, @S_ID, @Req_ID, @Item_Name, @Quantity, @Item_Cost)";

                            using (SqlCommand command = new SqlCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@U_ID", CurrentUserID);
                                command.Parameters.AddWithValue("@W_ID", WorkerID);
                                command.Parameters.AddWithValue("@S_ID", ServiceID);
                                command.Parameters.AddWithValue("@Req_ID", RequestID);
                                command.Parameters.AddWithValue("@Item_Name", row.Cells["ItemName"].Value);
                                command.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value);
                                command.Parameters.AddWithValue("@Item_Cost", row.Cells["Price"].Value);

                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    string updateQuery = "UPDATE Request SET Status = 'Finished' WHERE Req_ID = @Req_ID";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@Req_ID", RequestID);
                        updateCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Items added to cart successfully and request status updated to 'Finished'!");
                    dataGridView1.Rows.Clear();
                }

                this.Hide();
                CheckOut Co = new CheckOut(RequestID, 1);
                Co.Show();
                FormStateMgr.SwitchToForm(this, Co, CurrentUserID.ToString(), true); 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops!: {ex.Message}");
            }
        }

        private void AddingItemsToCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormStateMgr.SaveCurrentForm(this.Name, CurrentUserID.ToString(), true);
        }
    }
}
