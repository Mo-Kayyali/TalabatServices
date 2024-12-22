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
using System.Collections;
namespace TalabatServices
{
    public partial class UserMakingRequest : Form
    {
        public UserMakingRequest()
        {
            InitializeComponent();
        }
       // public string constring = "Data Source=DESKTOP;Initial Catalog=TalabatServices;Integrated Security=True;Trust Server Certificate=True";

        //string query = "SELECT S_ID, NAME FROM Services";





        private void UserMakingRequest_Load(object sender, EventArgs e)
        {
          //  SqlConnection con = new SqlConnection(constring);
           // con.Open();
           // SqlCommand command =new SqlCommand(query, con);

        }

        private void chooseservice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage UHP = new UserHomePage(1);
            UHP.Show();
        }
    }
}
