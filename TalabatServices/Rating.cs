using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalabatServices
{
    public partial class Rating : Form
    {
        public Rating()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile("Resources\\NotStar.png");
            pictureBox1.MouseEnter += PictureBox1_MouseEnter;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.Image = Image.FromFile("Resources\\NotStar.png");
            pictureBox2.MouseEnter += PictureBox2_MouseEnter;
            pictureBox2.MouseLeave += PictureBox2_MouseLeave;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox3.Image = Image.FromFile("Resources\\NotStar.png");
            pictureBox3.MouseEnter += PictureBox3_MouseEnter;
            pictureBox3.MouseLeave += PictureBox3_MouseLeave;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox4.Image = Image.FromFile("Resources\\NotStar.png");
            pictureBox4.MouseEnter += PictureBox4_MouseEnter;
            pictureBox4.MouseLeave += PictureBox4_MouseLeave;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox5.Image = Image.FromFile("Resources\\NotStar.png");
            pictureBox5.MouseEnter += PictureBox5_MouseEnter;
            pictureBox5.MouseLeave += PictureBox5_MouseLeave;
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox1.Click += PictureBox1_Click;
            pictureBox2.Click += PictureBox1_Click;
            pictureBox3.Click += PictureBox1_Click;
            pictureBox4.Click += PictureBox1_Click;
            pictureBox5.Click += PictureBox1_Click;
        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\LightStar.ico");
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\LightStar.ico");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox3.Image = Image.FromFile("Resources\\LightStar.ico");
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox3.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox4.Image = Image.FromFile("Resources\\LightStar.ico");
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox3.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox4.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox5.Image = Image.FromFile("Resources\\LightStar.ico");
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\LightStar.ico");
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\DimStar.ico");
        }
        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\LightStar.ico");
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\DimStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\DimStar.ico");
        }
        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox3.Image = Image.FromFile("Resources\\LightStar.ico");
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\DimStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\DimStar.ico");
            pictureBox3.Image = Image.FromFile("Resources\\DimStar.ico");
        }

        private void PictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox3.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox4.Image = Image.FromFile("Resources\\LightStar.ico");
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\DimStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\DimStar.ico");
            pictureBox3.Image = Image.FromFile("Resources\\DimStar.ico");
            pictureBox4.Image = Image.FromFile("Resources\\DimStar.ico");
        }

        private void PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox3.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox4.Image = Image.FromFile("Resources\\LightStar.ico");
            pictureBox5.Image = Image.FromFile("Resources\\LightStar.ico");
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Resources\\DimStar.ico");
            pictureBox2.Image = Image.FromFile("Resources\\DimStar.ico");
            pictureBox3.Image = Image.FromFile("Resources\\DimStar.ico");
            pictureBox4.Image = Image.FromFile("Resources\\DimStar.ico");
            pictureBox5.Image = Image.FromFile("Resources\\DimStar.ico");
        }
    }
}
