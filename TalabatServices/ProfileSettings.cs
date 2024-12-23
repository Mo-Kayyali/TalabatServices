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
        bool isWorker;
         private string Connection_String =
            @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public ProfileSettings(int ID, int FlagUserWorker)
        {
            InitializeComponent();
            Flag0user1worker = FlagUserWorker;
            id = ID;
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Flag0user1worker == 0) // user is clicking
            {
                isWorker = false;
                this.Hide();
                UserHomePage UHP = new UserHomePage(id);
                FormStateMgr.SwitchToForm(this, UHP, id.ToString(), isWorker);
                UHP.Show();
            }
            else // worker is clicking
            {
                isWorker = true;
                this.Hide();
                WorkerHomePage workerHomePage = new WorkerHomePage(id);
                FormStateMgr.SwitchToForm(this, workerHomePage, id.ToString(), isWorker);
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
            if (Flag0user1worker == 0)
            {
                using (SqlConnection conn = new SqlConnection(Connection_String))
                {
                    conn.Open();
                    LoadUsersPhoneNumbersIntoCompoBox(conn);
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(Connection_String))
                {
                    conn.Open();
                    LoadWorkersPhoneNumbersIntoCompoBox(conn);
                }
            }
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

            if (Flag0user1worker == 0)
            {
                using (SqlConnection conn = new SqlConnection(Connection_String))
                {
                    conn.Open();
                    LoadUsersPhoneNumbersIntoCompoBox(conn);
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(Connection_String))
                {
                    conn.Open();
                    LoadWorkersPhoneNumbersIntoCompoBox(conn);
                }
            }

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
            using (SqlConnection conn = new SqlConnection(Connection_String))
            {
                conn.Open();
                LoadDistrictIntoCompoBox(conn);
            }

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
            using (SqlConnection conn = new SqlConnection(Connection_String))
            {
                conn.Open();
                LoadDistrictIntoCompoBox(conn);
            }
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
            using (SqlConnection conn = new SqlConnection(Connection_String))
            {
                conn.Open();
                LoadAddressIntoComboBox(conn);
            }
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
            using (SqlConnection conn = new SqlConnection(Connection_String))
            {
                conn.Open();
                LoadAddressIntoComboBox(conn);
            }
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
                                    command.Parameters.AddWithValue("@Change_Password", Change_Password);
                                    command.Parameters.AddWithValue("@id", id);

                                    command.ExecuteNonQuery();
                                    // Execute command
                                    //int rowsAffected = command.ExecuteNonQuery();

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
                                    command.Parameters.AddWithValue("@Change_Name", Change_Name);
                                    command.Parameters.AddWithValue("@id", id);

                                    // Execute command
                                    command.ExecuteNonQuery();

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
                                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                                    command.Parameters.AddWithValue("@id", id);

                                    // Execute command
                                    command.ExecuteNonQuery();

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
                            else
                            {
                                MessageBox.Show("Please Enter A Phone Number Just As Digit");
                            }
                        }

                        if (UserDel_Checkbox.Checked)
                        {

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
                               
                               
                                string Old_PhoneNumber = Phone_Combo.SelectedItem.ToString();
                                string New_PhoneNumber = Phone_Text.Text;

                                UpdateUsersPhoneNumber(Old_PhoneNumber, New_PhoneNumber, conn);

                            }
                        }






                        if (AddressDel_Checkbox.Checked)
                        {
                            if (AddressDel_Checkbox.Checked)
                            {

                                string selectedAddress = Address_Combo.SelectedItem.ToString();

                                // Split the selected address into individual components (assuming space is the separator)
                                string[] addressParts = selectedAddress.Split(' ');

                                if (addressParts.Length == 5)
                                {
                                    string district = addressParts[0];
                                    string streetName = addressParts[1];
                                    string buildingNo = addressParts[2];
                                    string apartmentNo = addressParts[3];
                                    string floorNo = addressParts[4];

                                    // SQL query to delete the record based on the primary key columns
                                    string query = @"DELETE FROM User_Addresses
                                                     WHERE Street_Name = @StreetName
                                                      AND Building_No = @BuildingNo
                                                        AND Apartment_No = @ApartmentNo
                                                          AND District = @District and U_ID = @id";

                                    using (SqlCommand cmd = new SqlCommand(query, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@StreetName", streetName);
                                        cmd.Parameters.AddWithValue("@BuildingNo", buildingNo);
                                        cmd.Parameters.AddWithValue("@ApartmentNo", apartmentNo);
                                        cmd.Parameters.AddWithValue("@District", district); // Assuming District is still required for better precision
                                        cmd.Parameters.AddWithValue("@id", id);

                                        cmd.ExecuteNonQuery();

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid address format.");
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
                                        //MessageBox.Show("Insert successful!");
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
                            string district = AddDistrict_Text.Text;
                            string streetName = Street_Text.Text;
                            string buildingNo = Building_Text.Text;
                            string apartmentNo = Apartment_Text.Text;
                            string floorNo = Floor_Text.Text;

                            // Validate the fields to ensure all are filled and the numeric fields are valid
                            if (!string.IsNullOrEmpty(district) && !string.IsNullOrEmpty(streetName) &&
                                !string.IsNullOrEmpty(buildingNo) && !string.IsNullOrEmpty(apartmentNo) &&
                                !string.IsNullOrEmpty(floorNo) && buildingNo.All(char.IsDigit) &&
                                apartmentNo.All(char.IsDigit) && floorNo.All(char.IsDigit))
                            {
                                // SQL query to update the address based on the primary key columns
                                string updateQuery = @"UPDATE User_Addresses
                                                   SET Street_Name = @StreetName,
                                                       Building_No = @BuildingNo,
                                                       Apartment_No = @ApartmentNo,
                                                       Floor_No = @FloorNo,
                                                       District = @District
                                                   WHERE Street_Name = @OldStreetName
                                                     AND Building_No = @OldBuildingNo
                                                     AND Apartment_No = @OldApartmentNo
                                                     AND U_ID = @id";

                                // Get the original address from ComboBox to use as the condition
                                string selectedAddress = Address_Combo.SelectedItem.ToString();
                                string[] addressParts = selectedAddress.Split(' ');
                                if (addressParts.Length == 5)
                                {
                                    string oldStreetName = addressParts[1];
                                    string oldBuildingNo = addressParts[2];
                                    string oldApartmentNo = addressParts[3];

                                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@StreetName", streetName);
                                        cmd.Parameters.AddWithValue("@BuildingNo", buildingNo);
                                        cmd.Parameters.AddWithValue("@ApartmentNo", apartmentNo);
                                        cmd.Parameters.AddWithValue("@FloorNo", floorNo);
                                        cmd.Parameters.AddWithValue("@District", district);
                                        cmd.Parameters.AddWithValue("@OldStreetName", oldStreetName);
                                        cmd.Parameters.AddWithValue("@OldBuildingNo", oldBuildingNo);
                                        cmd.Parameters.AddWithValue("@OldApartmentNo", oldApartmentNo);
                                        cmd.Parameters.AddWithValue("@id", id); // The User_ID

                                        cmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid address format.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please check your input. All fields are required and numeric fields must contain numbers.");
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
                            command.Parameters.AddWithValue("@id", id);
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
                                reader.Close();
                            }
                        }

                        if (!string.IsNullOrEmpty(Email_Textbox.Text) && Regex.IsMatch(Email_Textbox.Text, "@"))
                        {
                            try
                            {
                                string Change_Email = Email_Textbox.Text;
                                string Change_EmailSQL = @"Update Workers set Email = @Change_Email where W_ID =@id ";

                                // Create command OF Change Email
                                using (SqlCommand EmailCommand = new SqlCommand(Change_EmailSQL, conn))
                                {
                                    // Add parameters
                                    EmailCommand.Parameters.AddWithValue("@Change_Email", Change_Email);
                                    EmailCommand.Parameters.AddWithValue("@id", id);

                                    // Execute command
                                    int rowsAffected = EmailCommand.ExecuteNonQuery();

                                    // Feedback to user
                                    if (rowsAffected > 0)
                                    {
                                        //MessageBox.Show("Update successful!");
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
                                string Change_PasswordSQL = @"Update Workers set Password = @Change_Password where W_ID =@id ";

                                using (SqlCommand command = new SqlCommand(Change_PasswordSQL, conn))
                                {
                                    // Add parameters
                                    command.Parameters.AddWithValue("@Change_Password", Change_Password);
                                    command.Parameters.AddWithValue("@id", id);

                                    // Execute command
                                    int rowsAffected = command.ExecuteNonQuery();

                                    // Feedback to user
                                    if (rowsAffected > 0)
                                    {
                                        //MessageBox.Show("Update successful!");
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
                                string Change_NameSQL = @"Update Workers set Name = @Change_Name where W_ID = @id";

                                using (SqlCommand command = new SqlCommand(Change_NameSQL, conn))
                                {
                                    // Add parameters
                                    command.Parameters.AddWithValue("@Change_Name", Change_Name);
                                    command.Parameters.AddWithValue("@id", id);

                                    // Execute command
                                    int rowsAffected = command.ExecuteNonQuery();

                                    // Feedback to user
                                    if (rowsAffected > 0)
                                    {
                                        //MessageBox.Show("Update successful!");
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
                            string Add_PhoneSql = @"INSERT INTO Worker_Phones (W_ID,Phone) VALUES (@id,@PhoneNumber)";

                            if (Phone_Text.Text.All(char.IsDigit) && !string.IsNullOrEmpty(Phone_Text.Text))
                            {
                                string PhoneNumber = Phone_Text.Text;
                                using (SqlCommand command = new SqlCommand(Add_PhoneSql, conn))
                                {
                                    // Add parameters
                                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                                    command.Parameters.AddWithValue("@id", id);

                                    // Execute command
                                    int rowsAffected = command.ExecuteNonQuery();


                                    if (rowsAffected > 0)
                                    {
                                        //MessageBox.Show("Update successful!");
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
                                return;
                            }
                        }

                        if (UserDel_Checkbox.Checked)
                        {
                            

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
                                string Old_PhoneNumber = Phone_Combo.SelectedItem.ToString();
                                string New_PhoneNumber = Phone_Text.Text;
                                UpdateWorkersPhoneNumber(Old_PhoneNumber, New_PhoneNumber, conn);

                            }
                        }
                        if (DistrictAdd_Checkbox.Checked)
                        {
                            string query = @"INSERT INTO Worker_Districts (W_ID,District) VALUES (@id,@District)";

                            if (!string.IsNullOrEmpty(District_Text.Text))
                            {
                                string District = District_Text.Text;
                                using (SqlCommand command = new SqlCommand(query, conn))
                                {
                                    // Add parameters
                                    command.Parameters.AddWithValue("@District", District);
                                    command.Parameters.AddWithValue("@id", id);

                                    // Execute command
                                    int rowsAffected = command.ExecuteNonQuery();


                                    if (rowsAffected > 0)
                                    {
                                        //MessageBox.Show("Update successful!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No rows updated. Check your condition.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter The District!?");
                            }
                        }
                        if (DistrictEdit_Checkbox.Checked)
                        {
                            if (!string.IsNullOrEmpty(District_Text.Text))
                            {
                                string Old_District = District_Combo.SelectedItem.ToString();
                                string New_District = District_Text.Text;
                                UpdateWorkersDistrict(Old_District, New_District, conn);

                            }
                        }
                        if (DistrictDel_Checkbox.Checked)
                        {
                            if (District_Combo.SelectedItem != null)
                            {
                                string District = District_Combo.SelectedItem.ToString();
                                DistrictDelete(District, conn);
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









        private void DistrictDelete(string district,SqlConnection conn)
        {
            string query = @"delete from Worker_Districts where W_ID=@WorkerID and District = @District";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@WorkerID", id);
            command.Parameters.AddWithValue("@District",district);

            try
            {
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error In Connection");
            }
        }
        private void UpdateWorkersDistrict(string Old_District, string New_District, SqlConnection conn)
        {
            string query = @"update Worker_Districts set District = @NewDistrict where District = @OldDistrict";



            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@NewDistrict", New_District);
            command.Parameters.AddWithValue("@OldDistrict", Old_District);
            try
            {

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error In Connection");
            }
        }
        private void LoadWorkersPhoneNumbersIntoCompoBox(SqlConnection conn)
        {

            string query = @"select Phone
                            from Worker_Phones
                            where W_ID = @Worker_id";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Worker_id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                Phone_Combo.Items.Clear();
                while (reader.Read())
                {
                    Phone_Combo.Items.Add(reader["Phone"].ToString());
                }
            }

        }

        private void LoadUsersPhoneNumbersIntoCompoBox(SqlConnection conn)
        {
            try
            {

                    string query = @"SELECT Phone
                                     FROM User_Phones
                                      WHERE U_ID = @User_id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User_id", id);
                        SqlDataReader reader = cmd.ExecuteReader();

                        Phone_Combo.Items.Clear();
                        while (reader.Read())
                        {
                            Phone_Combo.Items.Add(reader["Phone"].ToString());
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Services: {ex.Message}");
            }

        }
        private void LoadAddressIntoComboBox(SqlConnection conn)
        {
            string query = @"SELECT CONCAT(District, ' ', Street_Name, ' ', Building_No, ' ', Apartment_No, ' ', Floor_No) AS FullAddress
             FROM User_Addresses
             WHERE U_ID = @UserId";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", id);
                SqlDataReader reader = cmd.ExecuteReader();

                Address_Combo.Items.Clear();
                while (reader.Read())
                {
                    // Add the concatenated address to the ComboBox
                    Address_Combo.Items.Add(reader["FullAddress"].ToString());
                }
            }
        }
        private void LoadDistrictIntoCompoBox(SqlConnection conn)
        {

            string query = @"select District
                                from Worker_Districts
                                where W_ID = @WorkerID";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@WorkerID", id);
                SqlDataReader reader = cmd.ExecuteReader();

                District_Combo.Items.Clear();
                while (reader.Read())
                {
                    District_Combo.Items.Add(reader["District"].ToString());
                }
            }

        }
        private void DeleteUsersPhoneNumber(string phoneNumber, SqlConnection conn)
        {


            string DeletePhoneSql = @"Delete From User_Phones Where Phone =@phoneNumber ";



            SqlCommand command = new SqlCommand(DeletePhoneSql, conn);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    //MessageBox.Show("Delete Successfully");
                    Phone_Combo.Items.Remove(phoneNumber);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error In Connection11");
            }

        }

        private void DeleteWorkersPhoneNumber(string phoneNumber, SqlConnection conn)
        {


            string query = @"Delete From Worker_Phones Where Phone =@phoneNumber ";



            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            try
            {
               command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error In Connection");
            }

        }
        private void UpdateUsersPhoneNumber(string oldPhoneNumber, string newPhoneNumber, SqlConnection conn)
        {

            string Edit_Phone_Sql = @"Update User_Phones set Phone =@NewPhoneNumber Where Phone =@oldPhoneNumber";



            SqlCommand command = new SqlCommand(Edit_Phone_Sql, conn);
            command.Parameters.AddWithValue("@NewPhoneNumber", newPhoneNumber);
            command.Parameters.AddWithValue("@oldPhoneNumber", oldPhoneNumber);


            try
            {

                command.ExecuteNonQuery();
 

            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error In Connection");
            }

        }

        private void UpdateWorkersPhoneNumber(string oldPhoneNumber, string newPhoneNumber, SqlConnection conn)
        {

            string query = @"Update Worker_Phones set Phone =@NewPhoneNumber Where Phone =@oldPhoneNumber ";



            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@NewPhoneNumber", newPhoneNumber);
            command.Parameters.AddWithValue("@oldPhoneNumber", oldPhoneNumber);


            try
            {

              command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There are Error In Connection");
            }

        }

        private void ProfileSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormStateMgr.SaveCurrentForm(this.Name, id.ToString(), isWorker);
        }
    }
}