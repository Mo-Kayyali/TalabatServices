namespace TalabatServices
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Login_Button = new Button();
            Email_Textbox = new TextBox();
            Password_Textbox = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            Sign_Up_Button = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Login_Button
            // 
            Login_Button.BackColor = Color.FromArgb(41, 128, 185);
            Login_Button.FlatStyle = FlatStyle.Flat;
            Login_Button.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_Button.ForeColor = Color.White;
            Login_Button.Location = new Point(399, 389);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(157, 58);
            Login_Button.TabIndex = 0;
            Login_Button.Text = "LOGIN";
            Login_Button.UseVisualStyleBackColor = false;
            // 
            // Email_Textbox
            // 
            Email_Textbox.BackColor = SystemColors.ButtonFace;
            Email_Textbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email_Textbox.Location = new Point(323, 252);
            Email_Textbox.Name = "Email_Textbox";
            Email_Textbox.Size = new Size(376, 34);
            Email_Textbox.TabIndex = 1;
            // 
            // Password_Textbox
            // 
            Password_Textbox.BackColor = SystemColors.ButtonFace;
            Password_Textbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_Textbox.Location = new Point(323, 332);
            Password_Textbox.Name = "Password_Textbox";
            Password_Textbox.Size = new Size(376, 34);
            Password_Textbox.TabIndex = 2;
            Password_Textbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(361, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 40);
            label1.TabIndex = 3;
            label1.Text = "Login Panel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(216, 253);
            label4.Name = "label4";
            label4.Size = new Size(101, 33);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(41, 128, 185);
            label5.Location = new Point(156, 333);
            label5.Name = "label5";
            label5.Size = new Size(169, 33);
            label5.TabIndex = 8;
            label5.Text = "PASSWORD";
            // 
            // Sign_Up_Button
            // 
            Sign_Up_Button.BackColor = Color.FromArgb(41, 128, 185);
            Sign_Up_Button.FlatStyle = FlatStyle.Flat;
            Sign_Up_Button.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sign_Up_Button.ForeColor = Color.White;
            Sign_Up_Button.Location = new Point(399, 463);
            Sign_Up_Button.Name = "Sign_Up_Button";
            Sign_Up_Button.Size = new Size(157, 58);
            Sign_Up_Button.TabIndex = 9;
            Sign_Up_Button.Text = "Sign Up";
            Sign_Up_Button.UseVisualStyleBackColor = false;
            Sign_Up_Button.Click += Sign_Up_Button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(96, 319);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(253, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(446, 182);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 533);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Sign_Up_Button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Password_Textbox);
            Controls.Add(Email_Textbox);
            Controls.Add(Login_Button);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_Button;
        private TextBox Email_Textbox;
        private TextBox Password_Textbox;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button Sign_Up_Button;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
