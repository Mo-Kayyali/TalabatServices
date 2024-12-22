namespace TalabatServices
{
    partial class UserHomePage
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
            label1 = new Label();
            subheadline = new Label();
            getstarted = new Button();
            setting = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 158);
            label1.Location = new Point(172, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(652, 63);
            label1.TabIndex = 0;
            label1.Text = "find trusted services near you";
            // 
            // subheadline
            // 
            subheadline.AutoEllipsis = true;
            subheadline.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            subheadline.ForeColor = Color.FromArgb(41, 128, 185);
            subheadline.Location = new Point(226, 113);
            subheadline.Name = "subheadline";
            subheadline.Size = new Size(555, 127);
            subheadline.TabIndex = 1;
            subheadline.Text = "Choose from variety of services and get connected with reliable professionals in your area";
            subheadline.TextAlign = ContentAlignment.MiddleCenter;
            subheadline.UseCompatibleTextRendering = true;
            subheadline.Click += label2_Click;
            // 
            // getstarted
            // 
            getstarted.BackColor = Color.FromArgb(41, 128, 185);
            getstarted.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            getstarted.Location = new Point(415, 336);
            getstarted.Name = "getstarted";
            getstarted.Size = new Size(176, 61);
            getstarted.TabIndex = 2;
            getstarted.Text = "GET STARTED";
            getstarted.UseVisualStyleBackColor = false;
            getstarted.Click += button1_Click;
            // 
            // setting
            // 
            setting.BackColor = Color.FromArgb(41, 128, 185);
            setting.Location = new Point(894, 29);
            setting.Name = "setting";
            setting.Size = new Size(94, 43);
            setting.TabIndex = 3;
            setting.Text = "Settings";
            setting.UseVisualStyleBackColor = false;
            setting.Click += setting_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(32, 460);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 23);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "contact us";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(142, 460);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(79, 23);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "follow us";
            // 
            // UserHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Proj_pic;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1000, 518);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(setting);
            Controls.Add(getstarted);
            Controls.Add(subheadline);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "UserHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserHomePage";
            Load += UserHomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label subheadline;
        private Button getstarted;
        private Button setting;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}