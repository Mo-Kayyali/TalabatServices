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
    }
}
