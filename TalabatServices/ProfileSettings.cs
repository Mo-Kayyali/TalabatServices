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
        private int Flag0user1worker;
        public ProfileSettings(int FlagUserWorker )
        {
            InitializeComponent();
            Flag0user1worker = FlagUserWorker;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Flag0user1worker==0) // user is clicking
            {
                this.Hide();
                UserHomePage UHP = new UserHomePage();
                UHP.Show();
            }
            else // worker is clicking
            {
                this.Hide();
                WorkerHomePage workerHomePage = new WorkerHomePage(1);
                workerHomePage.Show();
            }

        }

        private void ProfileSettings_Load(object sender, EventArgs e)
        {
            //m7tagen lesa n2smha le user w worker 3shan nzhr district lel worker but not for user, the oppsite for the user tzhr address but not districts
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
            label10.Hide();
            label9.Hide();
            label8.Hide();
            label11.Hide();
            label12.Hide();

            if (Flag0user1worker==0) 
            {
                DistrictAdd_Checkbox.Hide();
                DistrictEdit_Checkbox.Hide();
                DistrictDel_Checkbox.Hide();
                label6.Hide();
                District_Text.Hide();
                District_Combo.Hide();
                AddressAdd_Checkbox.Location = new Point(2, 280);
                AddressEdit_Checkbox.Location = new Point(89, 280);
                AddressDel_Checkbox.Location = new Point(184, 280);
                label7.Location = new Point(308, 280);
                AddDistrict_Text.Location = new Point(713, 280);
                label10.Location = new Point(510, 282);
                Street_Text.Location = new Point(713, 338);
                label9.Location = new Point(510, 340);
                label8.Location = new Point(510, 394);
                Building_Text.Location = new Point(713, 390);
                Apartment_Text.Location = new Point(713, 447);
                label11.Location = new Point(510, 451);
                Address_Combo.Location = new Point(969, 280);
                label12.Location = new Point(505, 508);
                Floor_Text.Location = new Point(712, 508);
            }
            else
            {
                AddressAdd_Checkbox.Hide();
                AddressEdit_Checkbox.Hide();
                AddressDel_Checkbox.Hide();
                label7.Hide();

            }
            
        }
        private void UserAdd_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (UserAdd_Checkbox.Checked)
            {
                UserEdit_Checkbox.Checked = false;
                UserDel_Checkbox.Checked = false;
                Phone_Text.Show();
            }
            else
            {
                Phone_Text.Hide();
            }
        }

        private void UserEdit_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (UserEdit_Checkbox.Checked)
            {
                UserAdd_Checkbox.Checked = false;
                UserDel_Checkbox.Checked = false;
                Phone_Text.Show();
                Phone_Combo.Show();
            }
            else
            {
                Phone_Text.Hide();
                Phone_Combo.Hide();
            }
        }

        private void UserDel_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (UserDel_Checkbox.Checked)
            {
                UserAdd_Checkbox.Checked = false;
                UserEdit_Checkbox.Checked = false;
                Phone_Combo.Show();
                Phone_Combo.Location = new Point(510, 219);
            }
            else
            {
                Phone_Combo.Location = new Point(968, 219);
                Phone_Combo.Hide();
            }
        }

        private void DistrictAdd_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (DistrictAdd_Checkbox.Checked)
            {
                DistrictEdit_Checkbox.Checked = false;
                DistrictDel_Checkbox.Checked = false;
                District_Text.Show();
            }
            else
            {
                District_Text.Hide();
            }
        }

        private void DistrictEdit_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (DistrictEdit_Checkbox.Checked)
            {
                DistrictAdd_Checkbox.Checked = false;
                DistrictDel_Checkbox.Checked = false;
                District_Text.Show();
                District_Combo.Show();
            }
            else
            {
                District_Text.Hide();
                District_Combo.Hide();
            }

        }

        private void DistrictDel_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (DistrictDel_Checkbox.Checked)
            {
                DistrictEdit_Checkbox.Checked = false;
                DistrictAdd_Checkbox.Checked = false;
                District_Combo.Show();
                District_Combo.Location = new Point(511, 280);
            }
            else
            {
                District_Combo.Hide();
                District_Combo.Location = new Point(969, 280);
            }
        }

        private void AddressAdd_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddressAdd_Checkbox.Checked)
            {
                AddressEdit_Checkbox.Checked = false;
                AddressDel_Checkbox.Checked = false;
                AddDistrict_Text.Show();
                Street_Text.Show();
                Building_Text.Show();
                Apartment_Text.Show();
                Floor_Text.Show();
                label10.Show();
                label9.Show();
                label8.Show();
                label11.Show();
                label12.Show();
            }
            else
            {
                AddDistrict_Text.Hide();
                Street_Text.Hide();
                Building_Text.Hide();
                Apartment_Text.Hide();
                Floor_Text.Hide();
                label10.Hide();
                label9.Hide();
                label8.Hide();
                label11.Hide();
                label12.Hide();

            }
        }

        private void AddressEdit_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddressEdit_Checkbox.Checked)
            {
                AddressAdd_Checkbox.Checked = false;
                AddressDel_Checkbox.Checked = false;
                AddDistrict_Text.Show();
                Address_Combo.Show();
                Street_Text.Show();
                Building_Text.Show();
                Apartment_Text.Show();
                Floor_Text.Show();
                label10.Show();
                label9.Show();
                label8.Show();
                label11.Show();
                label12.Show();

            }
            else
            {
                Address_Combo.Hide();
                AddDistrict_Text.Hide();
                Street_Text.Hide();
                Building_Text.Hide();
                Apartment_Text.Hide();
                Floor_Text.Hide();
                label10.Hide();
                label9.Hide();
                label8.Hide();
                label11.Hide();
                label12.Hide();

            }

                
        }

        private void AddressDel_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddressDel_Checkbox.Checked)
            {
                AddressAdd_Checkbox.Checked = false;
                AddressEdit_Checkbox.Checked = false;
                Address_Combo.Show();
                Address_Combo.Location = new Point(510, 279);

            }
            else
            {
                Address_Combo.Hide();
                Address_Combo.Location = new Point(969, 280);
            }

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

