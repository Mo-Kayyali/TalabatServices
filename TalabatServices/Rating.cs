using System;
using System.Windows.Forms;

namespace TalabatServices
{
    public partial class Rating : Form
    {
        public Boolean FlagClick1 = false;
        public Boolean FlagClick2 = false;
        public Boolean FlagClick3 = false;
        public Boolean FlagClick4 = false;
        public Boolean FlagClick5 = false;

        public Rating()
        {
            InitializeComponent();

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
    }
}
