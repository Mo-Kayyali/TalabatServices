using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;

namespace TalabatServices
{
    //FormNum0
    public partial class SignUp : Form
    {
        bool isWorker;

        public SignUp()
        {
            InitializeComponent();
            this.User_Checkbox.CheckedChanged += new System.EventHandler(this.User_Checkbox_CheckedChanged);
            this.Worker_Checkbox.CheckedChanged += new System.EventHandler(this.Worker_Checkbox_CheckedChanged);
            this.FormClosing += new FormClosingEventHandler(Signup_FormClosing);
        }


        private void SignUp_Load(object sender, EventArgs e)
        {
            LoadServices();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            Name_Textbox.Hide();
            Email_Textbox.Hide();
            Password_Textbox.Hide();
            Phonenumber_Textbox.Hide();
            Phonenumber2_Textbox.Hide();
            Service_Combobox.Hide();
            District2_StreetName_Textbox.Hide();
            District_Textbox.Hide();
            Apartment_Textbox.Hide();
            Floor_Textbox.Hide();
            Building_Textbox.Hide();
            Create_Account_Button.Hide();
        }
        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Create_Account_Button_Click(object sender, EventArgs e)
        {
            string Name = Name_Textbox.Text;
            string Email = Email_Textbox.Text;
            string Password = Password_Textbox.Text;
            string PhoneNumber = Phonenumber_Textbox.Text;
            string PhoneNumber2 = Phonenumber2_Textbox.Text;
            string Service = Service_Combobox.Text;
            string District = District_Textbox.Text;
            string District2_StreetName = District2_StreetName_Textbox.Text;
            string Building = Building_Textbox.Text;
            string Apartment = Apartment_Textbox.Text;
            string Floor = Floor_Textbox.Text;

            if (User_Checkbox.Checked)
            {
                isWorker = false;
                if (string.IsNullOrEmpty(Name_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Name");
                    return;
                }
                if (string.IsNullOrEmpty(Email_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Email");
                    return;
                }
                if (string.IsNullOrEmpty(Password_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Password");
                    return;
                }
                if (string.IsNullOrEmpty(Phonenumber_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Phone Number");
                    return;
                }
                if (string.IsNullOrEmpty(District_Textbox.Text))
                {
                    MessageBox.Show("Please Enter District");
                    return;
                }
                if (string.IsNullOrEmpty(District2_StreetName_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Street Name");
                    return;
                }
                if (string.IsNullOrEmpty(Building_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Building Number");
                    return;
                }
                if (string.IsNullOrEmpty(Apartment_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Apartment Number");
                    return;
                }
                if (string.IsNullOrEmpty(Floor_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Floor Number");
                    return;
                }


                if (string.IsNullOrWhiteSpace(Phonenumber_Textbox.Text) || !Phonenumber_Textbox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid Phone Number.");
                    return;
                }
                if (!Phonenumber2_Textbox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid Optional Phone Number.");
                    return;
                }
                if (!Email_Textbox.Text.Contains("@"))
                {
                    MessageBox.Show("Please enter a valid email address containing '@'");
                }

                if (!Apartment_Textbox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter Apartment Number in Numbers.");
                    return;
                }
                if (!Floor_Textbox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter Floor Number in Numbers.");
                    return;
                }
                if (!Building_Textbox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter Building Number in Numbers.");
                    return;
                }



                string ConString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(ConString))
                {
                    try
                    {
                        conn.Open();

                        // Insert into Users table
                        string userqueryinsert = @"insert into Users(Name, Email, Password) OUTPUT INSERTED.U_ID values(@Name,@Email,@Password)";
                        SqlCommand SCM = new SqlCommand(userqueryinsert, conn);
                        SCM.Parameters.AddWithValue("@Name", Name);
                        SCM.Parameters.AddWithValue("@Email", Email);
                        SCM.Parameters.AddWithValue("@Password", Password);

                        int userID = (int)SCM.ExecuteScalar();

                        // Insert into User_Phones table
                        string userqueryinsert2 = @"insert into User_Phones(U_ID,Phone,CurrentlySelected) values(@U_ID,@PhoneNumber,@One)";
                        SCM = new SqlCommand(userqueryinsert2, conn);
                        SCM.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        SCM.Parameters.AddWithValue("@U_ID", userID);
                        SCM.Parameters.AddWithValue("@One", "1");
                        SCM.ExecuteNonQuery();

                        if (!String.IsNullOrEmpty(Phonenumber2_Textbox.Text))
                        {
                            string workerqueryinsert5 = @"INSERT INTO User_Phones(U_ID,Phone) VALUES (@U_ID,@PhoneNumber)";
                            SCM = new SqlCommand(workerqueryinsert5, conn);
                            SCM.Parameters.AddWithValue("@PhoneNumber", PhoneNumber2);
                            SCM.Parameters.AddWithValue("@U_ID", userID);
                            SCM.ExecuteNonQuery();
                        }

                        // Insert into User_Addresses table
                        string userqueryinsert3 = @"insert into User_Addresses(U_Id,Street_Name, Building_No, Apartment_No, District, Floor_No,CurrentlySelected) 
                                    values(@U_ID,@District2_StreetName, @Building, @Apartment, @District, @Floor,@One)";
                        SCM = new SqlCommand(userqueryinsert3, conn);
                        SCM.Parameters.AddWithValue("@U_ID", userID);
                        SCM.Parameters.AddWithValue("@District2_StreetName", District2_StreetName);
                        SCM.Parameters.AddWithValue("@Building", Building);
                        SCM.Parameters.AddWithValue("@Apartment", Apartment);
                        SCM.Parameters.AddWithValue("@District", District);
                        SCM.Parameters.AddWithValue("@Floor", Floor);
                        SCM.Parameters.AddWithValue("@One", "1");
                        SCM.ExecuteNonQuery();


                        MessageBox.Show("Account Created Successfully!");
                        this.Hide();
                        Login LG = new Login();
                        FormStateMgr.SwitchToForm(this, LG, userID.ToString(), isWorker);
                        LG.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }

            }
            else if (Worker_Checkbox.Checked)
            {
                isWorker = true;
                if (string.IsNullOrEmpty(Name_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Name");
                    return;
                }
                if (string.IsNullOrEmpty(Email_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Email");
                    return;
                }
                if (string.IsNullOrEmpty(Password_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Password");
                    return;
                }
                if (string.IsNullOrEmpty(Phonenumber_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Phone Number");
                    return;
                }
                if (string.IsNullOrEmpty(District_Textbox.Text))
                {
                    MessageBox.Show("Please Enter District");
                    return;
                }
                if (Service_Combobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter Select Service Ur Offering");
                    return;
                }


                if (string.IsNullOrWhiteSpace(Phonenumber_Textbox.Text) || !Phonenumber_Textbox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid Phone Number.");
                    return;
                }
                if (!Phonenumber2_Textbox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid Optional Phone Number.");
                    return;
                }
                if (!Email_Textbox.Text.Contains("@"))
                {
                    MessageBox.Show("Please enter a valid email address containing '@'");
                }






                string ConString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(ConString))
                {
                    try
                    {
                        conn.Open();

                        string workerqueryinsert = @"
            INSERT INTO Workers (Name, Email, Password, S_ID) 
            OUTPUT INSERTED.W_ID
            VALUES (@Name, @Email, @Password, 
                    (SELECT S.S_ID FROM Services S WHERE S.Name = @Service))";
                        SqlCommand SCM = new SqlCommand(workerqueryinsert, conn);
                        SCM.Parameters.AddWithValue("@Name", Name);
                        SCM.Parameters.AddWithValue("@Email", Email);
                        SCM.Parameters.AddWithValue("@Password", Password);
                        SCM.Parameters.AddWithValue("@Service", Service);

                        // Get the W_ID of the newly inserted worker
                        int workerId = (int)SCM.ExecuteScalar();

                        // Now insert into Worker_Phones table
                        string workerqueryinsert2 = @"INSERT INTO Worker_Phones (W_ID,Phone,CurrentlySelected) VALUES (@W_ID,@PhoneNumber,@One)";
                        SCM = new SqlCommand(workerqueryinsert2, conn);
                        SCM.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        SCM.Parameters.AddWithValue("@W_ID", workerId);
                        SCM.Parameters.AddWithValue("@One", "1");
                        SCM.ExecuteNonQuery();

                        if (!String.IsNullOrEmpty(Phonenumber2_Textbox.Text))
                        {
                            string workerqueryinsert5 = @"INSERT INTO Worker_Phones (W_ID,Phone) VALUES (@W_ID,@PhoneNumber)";
                            SCM = new SqlCommand(workerqueryinsert5, conn);
                            SCM.Parameters.AddWithValue("@PhoneNumber", PhoneNumber2);
                            SCM.Parameters.AddWithValue("@W_ID", workerId);
                            SCM.ExecuteNonQuery();
                        }

                        // Insert into Worker_Districts table using the captured W_ID
                        string workerqueryinsert3 = @"
            INSERT INTO Worker_Districts (W_ID, District,CurrentlySelected) 
            VALUES (@W_ID, @District,@One)";
                        SCM = new SqlCommand(workerqueryinsert3, conn);
                        SCM.Parameters.AddWithValue("@W_ID", workerId); // Use the captured W_ID
                        SCM.Parameters.AddWithValue("@District", District);
                        SCM.Parameters.AddWithValue("@One", "1");
                        SCM.ExecuteNonQuery();


                        if (!String.IsNullOrEmpty(District2_StreetName_Textbox.Text))
                        {
                            string workerqueryinsert4 = @"
            INSERT INTO Worker_Districts (W_ID, District) 
            VALUES (@W_ID, @District2_StreetName)";
                            SCM = new SqlCommand(workerqueryinsert4, conn);
                            SCM.Parameters.AddWithValue("@W_ID", workerId); // Use the captured W_ID
                            SCM.Parameters.AddWithValue("@District2_StreetName", District2_StreetName);
                            SCM.ExecuteNonQuery();
                        }

                        MessageBox.Show("Account Created Successfully!");
                        this.Hide();
                        Login LG = new Login();
                        FormStateMgr.SwitchToForm(this, LG, workerId.ToString(), isWorker);
                        LG.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }


        private void LoadServices()
        {
            try
            {
                string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Name FROM Services";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Service_Combobox.Items.Add(reader["Name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Services: {ex.Message}");
            }
        }
        private void User_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (User_Checkbox.Checked)
            {
                isWorker = false;
                Worker_Checkbox.Checked = false;
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                label11.Show();
                label12.Show();
                Name_Textbox.Show();
                Email_Textbox.Show();
                Password_Textbox.Show();
                Phonenumber_Textbox.Show();
                Phonenumber2_Textbox.Show();
                District2_StreetName_Textbox.Show();
                District_Textbox.Show();
                Apartment_Textbox.Show();
                Floor_Textbox.Show();
                Building_Textbox.Show();
                Create_Account_Button.Show();

                Service_Combobox.Hide();
                label13.Hide();
                label14.Hide();
            }
            else
            {
                isWorker = true;
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                Name_Textbox.Hide();
                Email_Textbox.Hide();
                Password_Textbox.Hide();
                Phonenumber_Textbox.Hide();
                Phonenumber2_Textbox.Hide();
                Service_Combobox.Hide();
                District2_StreetName_Textbox.Hide();
                District_Textbox.Hide();
                Apartment_Textbox.Hide();
                Floor_Textbox.Hide();
                Building_Textbox.Hide();
                Create_Account_Button.Hide();
            }
        }

        private void Worker_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Worker_Checkbox.Checked)
            {
                isWorker = true;
                User_Checkbox.Checked = false;
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Show();
                label13.Show();
                label14.Show();
                Name_Textbox.Show();
                Email_Textbox.Show();
                Password_Textbox.Show();
                Phonenumber_Textbox.Show();
                Phonenumber2_Textbox.Show();
                District2_StreetName_Textbox.Show();
                District_Textbox.Show();
                Apartment_Textbox.Hide();
                Floor_Textbox.Hide();
                Building_Textbox.Hide();
                Create_Account_Button.Show();
                Service_Combobox.Show();
            }
            else
            {
                isWorker = false;
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                Name_Textbox.Hide();
                Email_Textbox.Hide();
                Password_Textbox.Hide();
                Phonenumber_Textbox.Hide();
                Phonenumber2_Textbox.Hide();
                Service_Combobox.Hide();
                District2_StreetName_Textbox.Hide();
                District_Textbox.Hide();
                Apartment_Textbox.Hide();
                Floor_Textbox.Hide();
                Building_Textbox.Hide();
                Create_Account_Button.Hide();
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
