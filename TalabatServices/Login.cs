using System.Data.SqlClient;

namespace TalabatServices
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Sign_Up_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp Sign = new SignUp();
            Sign.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rating Rate = new Rating();
            Rate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRequestAccepted UR = new UserRequestAccepted();
            UR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkerAcceptedRequest WR = new WorkerAcceptedRequest();
            WR.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckOut CO = new CheckOut(1);
            CO.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileSettings PS = new ProfileSettings(0);
            PS.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddingItemsToCart ITTC = new AddingItemsToCart(1, 1, 1, 1);
            ITTC.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage UHP = new UserHomePage(1);
            UHP.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMakingRequest UMR = new UserMakingRequest();
            UMR.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkerHomePage WHP = new WorkerHomePage(1);
            WHP.Show();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string email = Email_Textbox.Text;
            string password = Password_Textbox.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Email and Password.");
                return;
            }

            string connectionString = @"Data Source=KAYYALIS-LAPTOP;Initial Catalog=TalabatServices;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check in Users table
                    string userQuery = "SELECT U_ID FROM Users WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(userQuery, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object userId = cmd.ExecuteScalar();

                    if (userId != null)
                    {
                        int U_ID = Convert.ToInt32(userId);
                        MessageBox.Show("Login Successful as User!");
                        this.Hide();
                        UserHomePage userHome = new UserHomePage(U_ID);
                        userHome.Show();
                        return;
                    }

                    // Check in Workers table
                    string workerQuery = "SELECT W_ID FROM Workers WHERE Email = @Email AND Password = @Password";
                    cmd = new SqlCommand(workerQuery, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object workerId = cmd.ExecuteScalar();

                    if (workerId != null)
                    {
                        int W_ID = Convert.ToInt32(workerId);
                        MessageBox.Show("Login Successful as Worker!");
                        this.Hide();
                        WorkerHomePage workerHome = new WorkerHomePage(W_ID);
                        workerHome.Show();
                        return;
                    }

                    MessageBox.Show("Invalid email or password.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }


        }
    }
}
