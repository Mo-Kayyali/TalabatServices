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
    }
}
