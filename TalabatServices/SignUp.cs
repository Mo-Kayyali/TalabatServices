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

namespace TalabatServices
{
    public partial class SignUp : Form
    {
        
        public SignUp()
        {
            InitializeComponent();
            this.User_Checkbox.CheckedChanged += new System.EventHandler(this.User_Checkbox_CheckedChanged);
            this.Worker_Checkbox.CheckedChanged += new System.EventHandler(this.Worker_Checkbox_CheckedChanged);
            this.FormClosing += new FormClosingEventHandler(Signup_FormClosing);
        }
        private void SignUp_Load(object sender, EventArgs e)
        {

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
                if (string.IsNullOrEmpty(Name_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Name");
                    return;
                }



                string ConString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(ConString))
                {
                    try
                    {
                        conn.Open();

                        // Insert into Users table
                        string userqueryinsert = @"insert into Users(Name, Email, Password) values(@Name,@Email,@Password)";
                        SqlCommand SCM = new SqlCommand(userqueryinsert, conn);
                        SCM.Parameters.AddWithValue("@Name", Name);
                        SCM.Parameters.AddWithValue("@Email", Email);
                        SCM.Parameters.AddWithValue("@Password", Password);
                        SCM.ExecuteNonQuery();

                        // Insert into User_Phones table
                        string userqueryinsert2 = @"insert into User_Phones(Phone) values(@PhoneNumber)";
                        SCM = new SqlCommand(userqueryinsert2, conn);
                        SCM.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        SCM.ExecuteNonQuery();

                        // Insert into User_Addresses table
                        string userqueryinsert3 = @"insert into User_Addresses(Street_Name, Building_No, Apartment_No, District, Floor_No) 
                                    values(@District2_StreetName, @Building, @Apartment, @District, @Floor)";
                        SCM = new SqlCommand(userqueryinsert3, conn);
                        SCM.Parameters.AddWithValue("@District2_StreetName", District2_StreetName);
                        SCM.Parameters.AddWithValue("@Building", Building);
                        SCM.Parameters.AddWithValue("@Apartment", Apartment);
                        SCM.Parameters.AddWithValue("@District", District);
                        SCM.Parameters.AddWithValue("@Floor", Floor);
                        SCM.ExecuteNonQuery();

                        MessageBox.Show("Account Created Successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }

            }else if (Worker_Checkbox.Checked)
            {
                if (string.IsNullOrEmpty(Name_Textbox.Text))
                {
                    MessageBox.Show("Please Enter Name");
                    return;
                }



                //string userqueryinsert = @"insert into Users(Name, Email, Password) values(@Name,@Email,@Password)";
                //string userqueryinsert2 = @"insert into User_Phones(Phone) values(@PhoneNumber)";
                //string userqueryinsert3 = @"insert into User_Addresses(Street_Name,Building_No,Apartment_No,District,Floor_No) values(@District2_StreetName,@Building,@Apartment,@Floor)";

                string ConString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(ConString))
                {
                    try
                    {
                        conn.Open();

                        // Insert into Users table
                        string userqueryinsert = @"insert into Users(Name, Email, Password) values(@Name,@Email,@Password)";
                        SqlCommand SCM = new SqlCommand(userqueryinsert, conn);
                        SCM.Parameters.AddWithValue("@Name", Name);
                        SCM.Parameters.AddWithValue("@Email", Email);
                        SCM.Parameters.AddWithValue("@Password", Password);
                        SCM.ExecuteNonQuery();

                        // Insert into User_Phones table
                        string userqueryinsert2 = @"insert into User_Phones(Phone) values(@PhoneNumber)";
                        SCM = new SqlCommand(userqueryinsert2, conn);
                        SCM.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        SCM.ExecuteNonQuery();

                        // Insert into User_Addresses table
                        string userqueryinsert3 = @"insert into User_Addresses(Street_Name, Building_No, Apartment_No, District, Floor_No) 
                                    values(@District2_StreetName, @Building, @Apartment, @District, @Floor)";
                        SCM = new SqlCommand(userqueryinsert3, conn);
                        SCM.Parameters.AddWithValue("@District2_StreetName", District2_StreetName);
                        SCM.Parameters.AddWithValue("@Building", Building);
                        SCM.Parameters.AddWithValue("@Apartment", Apartment);
                        SCM.Parameters.AddWithValue("@District", District);
                        SCM.Parameters.AddWithValue("@Floor", Floor);
                        SCM.ExecuteNonQuery();

                        MessageBox.Show("Account Created Successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select User Or Worker");
            }   

            



            if (User_Checkbox.Checked)
            {
                //
            }

        }

        private void User_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (User_Checkbox.Checked)
            {
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

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
