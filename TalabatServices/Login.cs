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
            CheckOut CO = new CheckOut();
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
            AddingItemsToCart ITTC = new AddingItemsToCart(1,1,1,1);
            ITTC.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage UHP = new UserHomePage();
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
    }
}
