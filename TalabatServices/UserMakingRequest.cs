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
using static System.Collections.Specialized.BitVector32;
namespace TalabatServices
{
    public partial class UserMakingRequest : Form
    {
        private int u_id;
        public UserMakingRequest(int U_ID)
        {
            InitializeComponent();
            u_id = U_ID;
        }
        //public string constring = "Data Source=DESKTOP;Initial Catalog=TalabatServices;Integrated Security=True;Trust Server Certificate=True";

       


        //private int GetServiceIdByName(string serviceName)
        //{
        //    SqlConnection con = new SqlConnection(constring);
        //    string query = "SELECT S_ID FROM Services WHERE Name = @ServiceName";
        //    using (SqlCommand command = new SqlCommand(query, con))
        //    {
        //        command.Parameters.AddWithValue("@ServiceName", serviceName);
        //        return (int)command.ExecuteScalar();
        //    }
        //}


        private void UserMakingRequest_Load(object sender, EventArgs e)
        {
            

        }

        private void chooseservice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage UHP = new UserHomePage(u_id);
            UHP.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void makrequest_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(constring);
         

            //try
            //{
            //    con.Open();

            //    string selectedService = chooseservice.SelectedItem.ToString();
            //    string Description = description.Text;
            //    DateTime startDate = dateTimePicker1.Value;
            //    DateTime endDate = dateTimePicker2.Value;

            //    int serviceId = GetServiceIdByName(selectedService);
            //    int userId = Session.UserId;

        //        string query = "INSERT INTO Request (U_ID, S_ID, Description, Start_Date, End_Date) VALUES (@UserId, @ServiceId, @Description, @StartDate, @EndDate)";

        //        using (SqlCommand command = new SqlCommand(query, con))
        //        {
        //            command.Parameters.AddWithValue("@UserId", userId);
        //            command.Parameters.AddWithValue("@ServiceId", serviceId);
        //            command.Parameters.AddWithValue("@Description", description);
        //            command.Parameters.AddWithValue("@StartDate", startDate);
        //            command.Parameters.AddWithValue("@EndDate", endDate);

        //            command.ExecuteNonQuery();
        //        }

        //        MessageBox.Show("Request has been successfully created.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        }

    }
    

}
