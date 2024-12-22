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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//if (string.IsNullOrWhiteSpace(Phonenumber_Textbox.Text) || !Phonenumber_Textbox.Text.All(char.IsDigit))
//{
//    MessageBox.Show("Please enter a valid Phone Number.");
//    return;
//}
//if (!Phonenumber2_Textbox.Text.All(char.IsDigit))
//{
//    MessageBox.Show("Please enter a valid Optional Phone Number.");
//    return;
//}
//if (!Email_Textbox.Text.Contains("@"))
//{
//    MessageBox.Show("Please enter a valid email address containing '@'");
//}

namespace TalabatServices
{
    public partial class ProfileSettings : Form
    {
        private int Flag0user1worker;
        private int id;

        public ProfileSettings(int ID, int FlagUserWorker)
        {
            InitializeComponent();
            Flag0user1worker = FlagUserWorker;
            id = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Flag0user1worker == 0) // user is clicking
            {
                this.Hide();
                UserHomePage UHP = new UserHomePage(id);
                UHP.Show();
            }
            else // worker is clicking
            {
                this.Hide();
                WorkerHomePage workerHomePage = new WorkerHomePage(id);
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

            if (Flag0user1worker == 0)
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
            @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void Login_Button_Click(object sender, EventArgs e)
        {

            if (Flag0user1worker == 0) // As User
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Connection_String))
                    {
                        string ConfirmSql = @"SELECT Password FROM Users WHERE U_ID = @id";

                        // Open connection
                        conn.Open();

                        // Create command Of Confirm Password
                        using (SqlCommand command = new SqlCommand(ConfirmSql, conn))
                        {
                            if (!string.IsNullOrEmpty(CnfPassword_Text.Text))
                            {
                                string EnteredPassword = CnfPassword_Text.Text;
                                command.Parameters.AddWithValue("@id", id);
                                SqlDataReader reader = command.ExecuteReader();

                                if (reader.Read())
                                {
                                    string storedPassword = reader["Password"].ToString();

                                    if (EnteredPassword == storedPassword)
                                    {
                                        MessageBox.Show("Successfully Updated The Settings");

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Enter A Right Password Again");
                                        return;

                                    }
                                }
                                reader.Close();
                            }
                            else
                            {
                                MessageBox.Show("Confirm Your Password!");
                            }
                        }

                        if (!string.IsNullOrEmpty(Email_Textbox.Text) && Regex.IsMatch(Email_Textbox.Text, "@"))
                        {
                            try
                            {
                                string Change_EmailSQL = @"Update Users set Email = @Change_Email where U_ID = @id";
                                string Change_Email = Email_Textbox.Text;

                                // Create command OF Change Email
                                using (SqlCommand EmailCommand = new SqlCommand(Change_EmailSQL, conn))
                                {
                                    // Add parameters
                                    EmailCommand.Parameters.AddWithValue("@Change_Email", Change_Email);
                                    EmailCommand.Parameters.AddWithValue("@id", id);

                                    EmailCommand.ExecuteNonQuery();

                                    // Execute command
                                    //int rowsAffected = EmailCommand.ExecuteNonQuery();

                                    //// Feedback to user
                                    //if (rowsAffected > 0)
                                    //{
                                    //    MessageBox.Show("Update successful!");
                                    //}
                                    //else
                                    //{
                                    //    MessageBox.Show("No rows updated. Check your condition.");

                                    //}
                                }

                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show("Error: " + exception.Message);

                            }

                        }

                        if (!String.IsNullOrEmpty(Chpassword_Text.Text))
                        {
                            try
                            {
                                string Change_PasswordSQL = @"Update Users set Password = @Change_Password where U_ID =@id ";
                                string Change_Password = Chpassword_Text.Text;

                                using (SqlCommand command = new SqlCommand(Change_PasswordSQL, conn))
                                {
                                    // Add parameters
                                    command.Parameters.AddWithValue("@Password", Change_Password);
                                    command.Parameters.AddWithValue("@id", id);

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
                            catch (Exception exception)
                            {
                                MessageBox.Show("There Are Error In Connection2");
                            }

                        }

                        if (!string.IsNullOrEmpty(Name_Text.Text))
                        {
                            try
                            {
                                string Change_NameSQL = @"Update Users set Name = @Change_Name where U_ID = @id";

                                string Change_Name = Name_Text.Text;

                                using (SqlCommand command = new SqlCommand(Change_NameSQL, conn))
                                {
                                    // Add parameters
                                    command.Parameters.AddWithValue("@Name", Change_Name);
                                    command.Parameters.AddWithValue("@id", id);

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
                            catch (Exception exception)
                            {
                                MessageBox.Show("There Are Error In Connection3");

                            }
                        }

                        if (UserAdd_Checkbox.Checked)
                        {
                            string Add_PhoneSql = @"INSERT INTO User_Phones (U_ID,Phone) VALUES (@id,@PhoneNumber)";

                            if (Phone_Text.Text.All(char.IsDigit) && !string.IsNullOrEmpty(Phone_Text.Text))
                            {
                                string PhoneNumber = Phone_Text.Text;
                                using (SqlCommand command = new SqlCommand(Add_PhoneSql, conn))
                                {
                                    // Add parameters
                                    command.Parameters.AddWithValue("@Phone", PhoneNumber);
                                    command.Parameters.AddWithValue("@id", id);

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
                            else
                            {
                                MessageBox.Show("Please Enter A Phone Number Just As Digit");
                            }
                        }

                        if (UserDel_Checkbox.Checked)
                        {
                            LoadUsersPhoneNumbersIntoCompoBox(conn);

                            if (Phone_Combo.SelectedItem != null)
                            {
                                string selectedPhoneNumber = Phone_Combo.SelectedItem.ToString();
                                DeleteUsersPhoneNumber(selectedPhoneNumber, conn);
                            }
                        }

                        if (UserEdit_Checkbox.Checked)
                        {

                            if (Phone_Text.Text.All(char.IsDigit) && !string.IsNullOrEmpty(Phone_Text.Text))
                            {
                                LoadUsersPhoneNumbersIntoCompoBox(conn);
                                string Old_PhoneNumber = Phone_Combo.SelectedItem.ToString();
                                string New_PhoneNumber = Phone_Text.Text;

                                UpdateUsersPhoneNumber(Old_PhoneNumber, New_PhoneNumber, conn);

                            }
                        }

                        if (AddressDel_Checkbox.Checked)
                        {
                            LoadDistrictIntoCompoBox(conn);

                            if (Address_Combo.SelectedItem != null)
                            {
                                string Selected_District = Address_Combo.SelectedItem.ToString();
                                string Delete_District_Sql =
                                    @"Delete from User_Addresses Where District = @Selected_District";
                                using (SqlCommand cmd = new SqlCommand(Delete_District_Sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Selected_District", Selected_District);

                                    try
                                    {
                                        int rowsAffected = cmd.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Delete Successfully");
                                            Phone_Combo.Items.Remove(Selected_District);
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("There are Error In Connection4");
                                    }
                                }
                            }
                        }

                        if (AddressAdd_Checkbox.Checked)
                        {
                            string District_text = AddDistrict_Text.Text;
                            string streetText = Street_Text.Text;
                            string buildingtext = Building_Text.Text;
                            string Apartment_text = Apartment_Text.Text;
                            string Floor_text = Floor_Text.Text;

                            string Add_District_Sql =
                                @"Insert into User_Addresses (U_ID,District,Street_Name,Building_No,Apartment_No,Floor_No)
                                                   Values (@id,@District,@Street_Name,@Building_No,@Apartment_No,@Floor_No)";


                            if (!string.IsNullOrEmpty(AddDistrict_Text.Text) && !string.IsNullOrEmpty(Street_Text.Text)
                                 && !string.IsNullOrEmpty(Building_Text.Text) && !string.IsNullOrEmpty(Apartment_Text.Text)
                                 && !string.IsNullOrEmpty(Floor_Text.Text) && Building_Text.Text.All(char.IsDigit)
                                 && Apartment_Text.Text.All(char.IsDigit) && Floor_Text.Text.All(char.IsDigit))
                            {

                                using (SqlCommand cmd = new SqlCommand(Add_District_Sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@District", District_text);
                                    cmd.Parameters.AddWithValue("@Street_Name", streetText);
                                    cmd.Parameters.AddWithValue("@Building_No", buildingtext);
                                    cmd.Parameters.AddWithValue("@Apartment_No", Apartment_text);
                                    cmd.Parameters.AddWithValue("@Floor_No", Floor_text);
                                    cmd.Parameters.AddWithValue("@id", id);

                                    // Execute command
                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    // Feedback to user
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Insert successful!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No rows Inserted. Check your condition.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Check Your Info");
                            }


                        }

                        if (AddressEdit_Checkbox.Checked)
                        {
                            string Old_District = Address_Combo.SelectedItem.ToString();
                            string District_text = AddDistrict_Text.Text;
                            string streetText = Street_Text.Text;
                            string buildingtext = Building_Text.Text;
                            string Apartment_text = Apartment_Text.Text;
                            string Floor_text = Floor_Text.Text;
                            // Queries Of Edit District
                            string District_Sql =
                                @"Update User_Addresses set District =@District Where District =@Old_District";
                            string Street_Sql =
                                @"Update User_Addresses set Street_Name =@Street_Name Where District =@Old_District";
                            string Building_Sql =
                                @"Update User_Addresses set Building_No =@Building_No Where District =@Old_District";
                            string Apartment_Sql =
                                @"Update User_Addresses set Apartment_No =@Apartment_No Where District =@Old_District";
                            string Floor_Sql =
                                @"Update User_Addresses set Floor_No =@Floor_No Where District =@Old_District";

                            LoadDistrictIntoCompoBox(conn);

                            if (!string.IsNullOrEmpty(AddDistrict_Text.Text))
                            {
                                using (SqlCommand cmd = new SqlCommand(District_Sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@District", District_text);
                                    cmd.Parameters.AddWithValue("@Old_District", Old_District);
                                    try
                                    {

                                        int rowsAffected = cmd.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Updated Successfully");


                                            Address_Combo.Items[Address_Combo.SelectedIndex] = District_text;
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("There are Error In Connection5");
                                    }
                                }
                            }

                            if (!string.IsNullOrEmpty(Street_Text.Text))
                            {
                                using (SqlCommand cmd = new SqlCommand(Street_Sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Street_Name", streetText);
                                    cmd.Parameters.AddWithValue("@Old_District", Old_District);
                                    try
                                    {

                                        int rowsAffected = cmd.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Updated Successfully");

                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("There are Error In Connection6");
                                    }
                                }
                            }

                            if (!string.IsNullOrEmpty(Building_Text.Text) && Building_Text.Text.All(char.IsDigit))
                            {
                                using (SqlCommand cmd = new SqlCommand(Building_Sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Building_No", buildingtext);
                                    cmd.Parameters.AddWithValue("@Old_District", Old_District);
                                    try
                                    {

                                        int rowsAffected = cmd.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Updated Successfully");

                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("There are Error In Connection7");
                                    }
                                }
                            }

                            if (!string.IsNullOrEmpty(Apartment_Text.Text) && Apartment_Text.Text.All(char.IsDigit))
                            {
                                using (SqlCommand cmd = new SqlCommand(Apartment_Sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Apartment_No", Apartment_text);
                                    cmd.Parameters.AddWithValue("@Old_District", Old_District);
                                    try
                                    {

                                        int rowsAffected = cmd.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Updated Successfully");

                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("There are Error In Connection8");
                                    }
                                }
                            }

                            if (!string.IsNullOrEmpty(Floor_Text.Text) && Floor_Text.Text.All(char.IsDigit))
                            {
                                using (SqlCommand cmd = new SqlCommand(Floor_Sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Floor_No", Floor_text);
                                    cmd.Parameters.AddWithValue("@Old_District", Old_District);
                                    try
                                    {

                                        int rowsAffected = cmd.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Updated Successfully");

                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("There are Error In Connection9");
                                    }
                                }
                            }
                        }


                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("There Are Error In Connection10");

                }

            }

            else if (Flag0user1worker == 1) // As Worker 
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Connection_String))
                    {
                        string ConfirmSql = @"SELECT Password FROM Workers WHERE W_ID = @id";

                        // Open connection
                        conn.Open();

                        // Create command Of Confirm Password
                        using (SqlCommand command = new SqlCommand(ConfirmSql, conn))
                        {
                            // Add parameters
                            command.Parameters.AddWithValue("@W_ID", id);
                            string EnteredPassword = CnfPassword_Text.Text;
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                string storedPassword = reader["Password"].ToString();

                                if (EnteredPassword == storedPassword)
                                {
                                    MessageBox.Show("Successfully");

                                }
                                else
                                {
                                    MessageBox.Show("Please Enter A Right Password Again");

                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(Email_Textbox.Text) && Regex.IsMatch(Email_Textbox.Text, "@"))
                        {
                            try
                            {
                                string Change_Email = Email_Textbox.Text;
                                string Change_EmailSQL = @"Update Workers set Email = @Change_Email where W_ID =id ";

                                // Create command OF Change Email
                                using (SqlCommand EmailCommand = new SqlCommand(Change_EmailSQL, conn))
                                {
                                    // Add parameters
                                    EmailCommand.Parameters.AddWithValue("@Email", Change_Email);

                                    // Execute command
                                    int rowsAffected = EmailCommand.ExecuteNonQuery();

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
                            catch (Exception exception)
                            {
                                MessageBox.Show("There Are Error In Connection");

                            }

                        }

                        if (!String.IsNullOrEmpty(Chpassword_Text.Text))
                        {
                            try
                            {
                                string Change_Password = Chpassword_Text.Text;
                                string Change_PasswordSQL = @"Update Workers set Password = @Change_Password where W_ID =id ";

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
                            catch (Exception exception)
                            {
                                MessageBox.Show("There Are Error In Connection");
                            }

                        }

                        if (!string.IsNullOrEmpty(Name_Text.Text))
                        {
                            try
                            {
                                string Change_Name = Name_Text.Text;
                                string Change_NameSQL = @"Update Workers set Name = @Change_Name where W_ID = id";

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
                            catch (Exception exception)
                            {
                                MessageBox.Show("There Are Error In Connection");

                            }
                        }

                        if (UserAdd_Checkbox.Checked)
                        {
                            string Add_PhoneSql = @"INSERT INTO Worker_Phones (Phone) VALUES (@PhoneNumber)";

                            if (Phone_Text.Text.All(char.IsDigit) && string.IsNullOrEmpty(Phone_Text.Text))
                            {
                                string PhoneNumber = Phone_Text.Text;
                                using (SqlCommand command = new SqlCommand(Add_PhoneSql, conn))
                                {
                                    // Add parameters
                                    command.Parameters.AddWithValue("@Phone", PhoneNumber);

                                    // Execute command
                                    int rowsAffected = command.ExecuteNonQuery();


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
                            else
                            {
                                MessageBox.Show("Please Enter A Phone Number Just As Digit");
                            }
                        }

                        if (UserDel_Checkbox.Checked)
                        {
                            LoadWorkersPhoneNumbersIntoCompoBox(conn);

                            if (Phone_Combo.SelectedItem != null)
                            {
                                string selectedPhoneNumber = Phone_Combo.SelectedItem.ToString();
                                DeleteWorkersPhoneNumber(selectedPhoneNumber, conn);
                            }
                        }

                        if (UserEdit_Checkbox.Checked)
                        {

                            if (Phone_Text.Text.All(char.IsDigit) && !string.IsNullOrEmpty(Phone_Text.Text))
                            {
                                LoadWorkersPhoneNumbersIntoCompoBox(conn);
                                string Old_PhoneNumber = Phone_Combo.SelectedItem.ToString();
                                string New_PhoneNumber = Phone_Text.Text;

                                UpdateWorkersPhoneNumber(Old_PhoneNumber, New_PhoneNumber, conn);

                            }
                        }

                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("There Are Error In Connection");
                }

            }




        }











        private void LoadWorkersPhoneNumbersIntoCompoBox(SqlConnection conn)
        {

            string PhoneNumbersSql = @"Select Phone From Worker_Phones";
            using (SqlCommand cmd = new SqlCommand(PhoneNumbersSql, conn))
            {

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Phone_Combo.Items.Add(reader["@Phone"].ToString());
                    }
                }

            }

        }

        private void LoadUsersPhoneNumbersIntoCompoBox(SqlConnection conn)
        {
            try
            {
                string PhoneNumbersSql = @"Select Phone From User_Phones";
                using (SqlCommand cmd = new SqlCommand(PhoneNumbersSql, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Phone_Combo.Items.Add(reader["@Phone"].ToString());
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Services: {ex.Message}");
            }

        }

        private void LoadDistrictIntoCompoBox(SqlConnection conn)
        {

            string DistrictSql = @"Select District From User_Addresses";
            using (SqlCommand cmd = new SqlCommand(DistrictSql, conn))
            {

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Address_Combo.Items.Add(reader["@District"].ToString());
                    }
                }

            }

        }
        private void DeleteUsersPhoneNumber(string phoneNumber, SqlConnection conn)
        {


            string DeletePhoneSql = @"Delete From User_Phones Where Phone =@phoneNumber ";



            SqlCommand command = new SqlCommand(DeletePhoneSql, conn);
            command.Parameters.AddWithValue("@Phone", phoneNumber);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delete Successfully");
                    Phone_Combo.Items.Remove(phoneNumber);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error In Connection");
            }

        }

        private void DeleteWorkersPhoneNumber(string phoneNumber, SqlConnection conn)
        {


            string DeletePhoneSql = @"Delete From Worker_Phones Where Phone =@phoneNumber ";



            SqlCommand command = new SqlCommand(DeletePhoneSql, conn);
            command.Parameters.AddWithValue("@Phone", phoneNumber);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delete Successfully");
                    Phone_Combo.Items.Remove(phoneNumber);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error In Connection");
            }

        }
        private void UpdateUsersPhoneNumber(string oldPhoneNumber, string newPhoneNumber, SqlConnection conn)
        {

            string Edit_Phone_Sql = @"Update User_Phones set Phone =@NnewPhoneNumber Where Phone =@oldPhoneNumber ";



            SqlCommand command = new SqlCommand(Edit_Phone_Sql, conn);
            command.Parameters.AddWithValue("@Phone", newPhoneNumber);


            try
            {

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated Successfully");


                    Phone_Combo.Items[Phone_Combo.SelectedIndex] = newPhoneNumber;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error In Connection");
            }

        }

        private void UpdateWorkersPhoneNumber(string oldPhoneNumber, string newPhoneNumber, SqlConnection conn)
        {

            string Edit_Phone_Sql = @"Update Worker_Phones set Phone =@NnewPhoneNumber Where Phone =@oldPhoneNumber ";



            SqlCommand command = new SqlCommand(Edit_Phone_Sql, conn);
            command.Parameters.AddWithValue("@Phone", newPhoneNumber);


            try
            {

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated Successfully");


                    Phone_Combo.Items[Phone_Combo.SelectedIndex] = newPhoneNumber;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error In Connection");
            }

        }
    }
}