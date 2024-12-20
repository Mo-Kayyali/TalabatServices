using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
