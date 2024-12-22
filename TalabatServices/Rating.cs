using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;  // Add this for SQL operations
using System.Windows.Forms;

namespace TalabatServices
{
    //FormNum6
    public partial class Rating : Form
    {
        private int userID;
        private int requestID;
        public Boolean FlagClick1 = false;
        public Boolean FlagClick2 = false;
        public Boolean FlagClick3 = false;
        public Boolean FlagClick4 = false;
        public Boolean FlagClick5 = false;

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public Rating(int Req_ID, int U_ID)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
            userID = U_ID;
            requestID = Req_ID;

            // Initialize PictureBox properties
            pictureBox1.Image = Properties.Resources.NotStar;
            pictureBox2.Image = Properties.Resources.NotStar;
            pictureBox3.Image = Properties.Resources.NotStar;
            pictureBox4.Image = Properties.Resources.NotStar;
            pictureBox5.Image = Properties.Resources.NotStar;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;

            // Assign Event Handlers
            pictureBox1.Click += PictureBox1_Click;
            pictureBox2.Click += PictureBox2_Click;
            pictureBox3.Click += PictureBox3_Click;
            pictureBox4.Click += PictureBox4_Click;
            pictureBox5.Click += PictureBox5_Click;

            pictureBox1.MouseEnter += PictureBox_MouseEnter;
            pictureBox2.MouseEnter += PictureBox_MouseEnter;
            pictureBox3.MouseEnter += PictureBox_MouseEnter;
            pictureBox4.MouseEnter += PictureBox_MouseEnter;
            pictureBox5.MouseEnter += PictureBox_MouseEnter;

            pictureBox1.MouseLeave += PictureBox_MouseLeave;
            pictureBox2.MouseLeave += PictureBox_MouseLeave;
            pictureBox3.MouseLeave += PictureBox_MouseLeave;
            pictureBox4.MouseLeave += PictureBox_MouseLeave;
            pictureBox5.MouseLeave += PictureBox_MouseLeave;
        }

        // Click Event Handlers
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FlagClick1 = true;
            FlagClick2 = false;
            FlagClick3 = false;
            FlagClick4 = false;
            FlagClick5 = false;
            UpdateStarRatings();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            FlagClick1 = true;
            FlagClick2 = true;
            FlagClick3 = false;
            FlagClick4 = false;
            FlagClick5 = false;
            UpdateStarRatings();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            FlagClick1 = true;
            FlagClick2 = true;
            FlagClick3 = true;
            FlagClick4 = false;
            FlagClick5 = false;
            UpdateStarRatings();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            FlagClick1 = true;
            FlagClick2 = true;
            FlagClick3 = true;
            FlagClick4 = true;
            FlagClick5 = false;
            UpdateStarRatings();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            FlagClick1 = true;
            FlagClick2 = true;
            FlagClick3 = true;
            FlagClick4 = true;
            FlagClick5 = true;
            UpdateStarRatings();
        }

        // Hover (MouseEnter) Event Handler
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender == pictureBox1)
            {
                pictureBox1.Image = Properties.Resources.Star;
            }
            else if (sender == pictureBox2)
            {
                pictureBox1.Image = Properties.Resources.Star;
                pictureBox2.Image = Properties.Resources.Star;
            }
            else if (sender == pictureBox3)
            {
                pictureBox1.Image = Properties.Resources.Star;
                pictureBox2.Image = Properties.Resources.Star;
                pictureBox3.Image = Properties.Resources.Star;
            }
            else if (sender == pictureBox4)
            {
                pictureBox1.Image = Properties.Resources.Star;
                pictureBox2.Image = Properties.Resources.Star;
                pictureBox3.Image = Properties.Resources.Star;
                pictureBox4.Image = Properties.Resources.Star;
            }
            else if (sender == pictureBox5)
            {
                pictureBox1.Image = Properties.Resources.Star;
                pictureBox2.Image = Properties.Resources.Star;
                pictureBox3.Image = Properties.Resources.Star;
                pictureBox4.Image = Properties.Resources.Star;
                pictureBox5.Image = Properties.Resources.Star;
            }
        }

        // Hover Out (MouseLeave) Event Handler
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            UpdateStarRatings();
        }

        // Update Star Ratings Based on Flags
        private void UpdateStarRatings()
        {
            pictureBox1.Image = FlagClick1 ? Properties.Resources.Star : Properties.Resources.NotStar;
            pictureBox2.Image = FlagClick2 ? Properties.Resources.Star : Properties.Resources.NotStar;
            pictureBox3.Image = FlagClick3 ? Properties.Resources.Star : Properties.Resources.NotStar;
            pictureBox4.Image = FlagClick4 ? Properties.Resources.Star : Properties.Resources.NotStar;
            pictureBox5.Image = FlagClick5 ? Properties.Resources.Star : Properties.Resources.NotStar;
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            // Any initialization code
        }

        private void Skip_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage UHP = new UserHomePage(userID);
            UHP.Show();
        }

        private void Sumbit_Button_Click(object sender, EventArgs e)
        {
            if (!FlagClick1 && !FlagClick2 && !FlagClick3 && !FlagClick4 && !FlagClick5)
            {
                MessageBox.Show("Please select a rating before submitting.");
                return;
            }

            int rate = 0;
            if (FlagClick1) rate++;
            if (FlagClick2) rate++;
            if (FlagClick3) rate++;
            if (FlagClick4) rate++;
            if (FlagClick5) rate++;

            // Get W_ID and S_ID from the Req_ID table
            int W_ID = 0, S_ID = 0;
            string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Update this with your connection string
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT W_ID, S_ID FROM Request WHERE Req_ID = @Req_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Req_ID", requestID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            W_ID = reader.GetInt32(0);  // W_ID
                            S_ID = reader.GetInt32(1);  // S_ID
                        }
                    }
                }
            }

            // Insert into Rate table
            string insertQuery = "INSERT INTO Rate (U_ID, W_ID, S_ID, Req_ID, Rate, Comment) VALUES (@U_ID, @W_ID, @S_ID, @Req_ID, @Rate, @Comment)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@U_ID", userID);
                    cmd.Parameters.AddWithValue("@W_ID", W_ID);
                    cmd.Parameters.AddWithValue("@S_ID", S_ID);
                    cmd.Parameters.AddWithValue("@Req_ID", requestID);
                    cmd.Parameters.AddWithValue("@Rate", rate);
                    cmd.Parameters.AddWithValue("@Comment", Comment_Textbox.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Thank you for your feedback!");
            this.Hide();
            UserHomePage UHP = new UserHomePage(userID);
            UHP.Show();
        }
    }
}
