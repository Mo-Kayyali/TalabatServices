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
    public partial class AddingItemsToCart : Form
    {
        public AddingItemsToCart()
        {
            InitializeComponent();
        }

        private void AddingItemsToCart_Load(object sender, EventArgs e)
        {
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
                MessageBox.Show("Please fullfil all boxes!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void SubmitToDB_Btn_Click(object sender, EventArgs e)
        {
            // This is a dummy code to show how to connect to a database and insert data from a DataGridView
            /*try
            {
                // DB Connection
                string connectionString = "Data Source=.;Initial Catalog=اسم_الداتابيز;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //  DataGridView to DB
     
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string query = @"
                        INSERT INTO Payment (U_ID, W_ID, S_ID, Req_ID, Item_Name, Quantity, Item_Cost) 
                        VALUES (@U_ID, @W_ID, @S_ID, @Req_ID, @Item_Name, @Quantity, @Item_Cost)";
                
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                    
                            command.Parameters.AddWithValue("@U_ID", CurrentUserID); // Replace with the logged-in user ID
                            command.Parameters.AddWithValue("@W_ID", WorkerID); // Replace with selected worker ID
                            command.Parameters.AddWithValue("@S_ID", ServiceID); // Replace with selected service ID
                            command.Parameters.AddWithValue("@Req_ID", RequestID); // Replace with associated request ID
                            command.Parameters.AddWithValue("@Item_Name", row.Cells["ItemNameColumn"].Value); // Adjust column name
                            command.Parameters.AddWithValue("@Quantity", row.Cells["QuantityColumn"].Value); // Adjust column name
                            command.Parameters.AddWithValue("@Item_Cost", row.Cells["CostColumn"].Value); // Adjust column name
                    
                            command.ExecuteNonQuery();
                         }
                    }
                }

                MessageBox.Show("Items added to cart successfully!");
                dataGridView1.Rows.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Oops!: {ex.Message}");
            }*/

            //need to connect this form with the checkout form here after submission
        }


    }
}
