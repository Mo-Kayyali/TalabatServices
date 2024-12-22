namespace TalabatServices
{
    partial class Rating
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Comment_Textbox = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            Sumbit_Button = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            Skip_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NotStar;
            pictureBox1.Location = new Point(153, 202);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Comment_Textbox
            // 
            Comment_Textbox.BackColor = SystemColors.ButtonFace;
            Comment_Textbox.BorderStyle = BorderStyle.FixedSingle;
            Comment_Textbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Comment_Textbox.Location = new Point(200, 70);
            Comment_Textbox.Multiline = true;
            Comment_Textbox.Name = "Comment_Textbox";
            Comment_Textbox.Size = new Size(540, 118);
            Comment_Textbox.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.NotStar;
            pictureBox2.Location = new Point(250, 202);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.NotStar;
            pictureBox3.Location = new Point(347, 202);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.NotStar;
            pictureBox4.Location = new Point(444, 202);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.NotStar;
            pictureBox5.Location = new Point(541, 202);
            pictureBox5.Margin = new Padding(0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // Sumbit_Button
            // 
            Sumbit_Button.BackColor = Color.FromArgb(41, 128, 185);
            Sumbit_Button.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Sumbit_Button.ForeColor = Color.White;
            Sumbit_Button.Location = new Point(298, 305);
            Sumbit_Button.Name = "Sumbit_Button";
            Sumbit_Button.Size = new Size(167, 56);
            Sumbit_Button.TabIndex = 6;
            Sumbit_Button.Text = "Submit";
            Sumbit_Button.UseVisualStyleBackColor = false;
            Sumbit_Button.Click += Sumbit_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(622, 33);
            label1.TabIndex = 7;
            label1.Text = "Please Provide A Rate For The Worker";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(41, 128, 185);
            label3.Location = new Point(26, 103);
            label3.Name = "label3";
            label3.Size = new Size(152, 33);
            label3.TabIndex = 9;
            label3.Text = "Comment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(182, 33);
            label2.TabIndex = 10;
            label2.Text = "(Optional)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(26, 136);
            label4.Name = "label4";
            label4.Size = new Size(159, 33);
            label4.TabIndex = 11;
            label4.Text = "Max (500)";
            // 
            // Skip_Button
            // 
            Skip_Button.BackColor = Color.Gray;
            Skip_Button.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Skip_Button.ForeColor = Color.White;
            Skip_Button.Location = new Point(630, 320);
            Skip_Button.Name = "Skip_Button";
            Skip_Button.Size = new Size(129, 41);
            Skip_Button.TabIndex = 12;
            Skip_Button.Text = "Skip";
            Skip_Button.UseVisualStyleBackColor = false;
            Skip_Button.Click += Skip_Button_Click;
            // 
            // Rating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(771, 373);
            ControlBox = false;
            Controls.Add(Skip_Button);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Sumbit_Button);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Comment_Textbox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rating";
            Text = "Rating";
            Load += Rating_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox Comment_Textbox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button Sumbit_Button;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button Skip_Button;
    }
}