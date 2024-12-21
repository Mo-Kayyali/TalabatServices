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
    public partial class UserHomePage : Form
    {
        public UserHomePage()
        {
            InitializeComponent();
        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection()
            this.Hide();
            UserMakingRequest UMR = new UserMakingRequest();
            UMR.Show();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileSettings PS = new ProfileSettings();
            PS.Show();
        }
    }
}
