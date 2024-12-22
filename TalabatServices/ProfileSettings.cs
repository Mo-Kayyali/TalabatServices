using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TalabatServices
{
    public partial class ProfileSettings : Form
    {
        public ProfileSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true) // user is clicking
            {
                this.Hide();
                UserHomePage UHP = new UserHomePage();
                UHP.Show();
            }
            else // worker is clicking
            {
                this.Hide();
                WorkerHomePage workerHomePage = new WorkerHomePage();
                workerHomePage.Show();
            }

        }

        private void ProfileSettings_Load(object sender, EventArgs e)
        {
            Phone_Text.Hide();
            AddDistrict_Text.Hide();
            Street_Text.Hide();
            Building_Text.Hide();
            Apartment_Text.Hide();
            Floor_Text.Hide();
            District_Text.Hide();
            District_Combo.Hide();
            Address_Combo.Hide();
            Phone_Combo.Hide();
        }


        private string Connection_String =
            @"Data Source=DESKTOP-1PC44GN;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
     
        private void Login_Button_Click(object sender, EventArgs e)
        {
            string Change_Email = Email_Textbox.Text;
            string Change_Password = Chpassword_Text.Text;
            string Change_Name = Name_Text.Text;
            string UserPhone = Phone_Text.Text;
           
            string Change_EmailSQL = @"Update Users set Email = @Change_Email where U_ID = ";
            string Change_PasswordSQL = @"Update Users set Password = @Change_Password where U_ID = ";
            string Change_NameSQL = @"Update Users set Name = @Change_Name where U_ID = ";
            string Add_PhoneSql = @"INSERT INTO User_Phones (Phone) VALUES (@Add_UserPhone)";
            string PhoneNumbersSql = @"Select Phone From User_Phones";
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection_String))
                {
                    // Open connection
                    conn.Open();

                    // Create command OF Change Email
                    using (SqlCommand command = new SqlCommand(Change_EmailSQL, conn))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Email", Change_Email);

                        // Execute command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Feedback to user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful!");
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. Check your condition.");
                        }
                    }
                }

                // Create command OF Change Password
                using (SqlConnection conn = new SqlConnection(Connection_String))
                {
                    // Open connection
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(Change_PasswordSQL, conn))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Password", Change_Password);

                        // Execute command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Feedback to user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful!");
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. Check your condition.");
                        }
                    }
                }

                // Create command OF Change Name

                using (SqlConnection conn = new SqlConnection(Connection_String))
                {
                    // Open connection
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(Change_NameSQL, conn))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Name", Change_Name);

                        // Execute command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Feedback to user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful!");
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. Check your condition.");
                        }
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error ");
            }


            if (User_Checkbox.Checked)
            {
                using (SqlConnection conn = new SqlConnection(Connection_String))
                {
                    // Open connection
                    conn.Open();

                    // Create command OF Change Email
                    using (SqlCommand command = new SqlCommand(Change_EmailSQL, conn))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Phone", Add_Phone);

                        // Execute command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Feedback to user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful!");
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. Check your condition.");
                        }
                    }
                }
            }

            if (checkBox2.Checked)
            {
                using (SqlConnection conn = new SqlConnection(Connection_String))
                {
                    // Open connection
                    conn.Open();

                    // Create command OF Change Email
                    using (SqlCommand cmd = new SqlCommand(PhoneNumbersSql, conn))
                    {

                        using (SqlDataReader reader =cmd.ExecuteReader() )
                        {
                            while (reader.Read())
                            {
                                Phone_Combo.Items.Add(reader["@Phone"].ToString());
                            }
                        }
                      
                    }
                }

            }




        }
    }
}
