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

namespace TalabatServices
{
    //FormNum2
    public partial class UserHomePage : Form
    {
        private int userID;

        public UserHomePage(int U_ID)
        {
            InitializeComponent();
            userID = U_ID;
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //SqlConnection conn = new SqlConnection();
            this.Hide();
            UserMakingRequest UMR = new UserMakingRequest(userID);
            UMR.Show();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileSettings PS = new ProfileSettings(userID,0);
            PS.Show();
        }
    }
}
