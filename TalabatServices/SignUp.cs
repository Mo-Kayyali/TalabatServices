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
        //SqlConnection conn = new SqlConnection(@"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
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
