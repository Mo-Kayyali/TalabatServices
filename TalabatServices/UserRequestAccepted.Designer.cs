namespace TalabatServices
{
    partial class UserRequestAccepted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRequestAccepted));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            phone = new TextBox();
            label4 = new Label();
            rating = new TextBox();
            name = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(13, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 38);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(67, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(377, 46);
            label2.TabIndex = 2;
            label2.Text = "Worker Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(41, 128, 185);
            label3.Location = new Point(13, 214);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 38);
            label3.TabIndex = 3;
            label3.Text = "Phone";
            // 
            // phone
            // 
            phone.BackColor = SystemColors.ButtonFace;
            phone.BorderStyle = BorderStyle.FixedSingle;
            phone.Location = new Point(150, 214);
            phone.Margin = new Padding(4);
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Size = new Size(277, 39);
            phone.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(13, 307);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 38);
            label4.TabIndex = 5;
            label4.Text = "Rating";
            // 
            // rating
            // 
            rating.BackColor = SystemColors.ButtonFace;
            rating.BorderStyle = BorderStyle.FixedSingle;
            rating.Location = new Point(150, 307);
            rating.Margin = new Padding(4);
            rating.Name = "rating";
            rating.ReadOnly = true;
            rating.Size = new Size(277, 39);
            rating.TabIndex = 6;
            // 
            // name
            // 
            name.BackColor = SystemColors.ButtonFace;
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Location = new Point(150, 124);
            name.Margin = new Padding(4);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(277, 39);
            name.TabIndex = 1;
            // 
            // UserRequestAccepted
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(522, 454);
            Controls.Add(rating);
            Controls.Add(label4);
            Controls.Add(phone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "UserRequestAccepted";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += UserRequestAccepted_FormClosed;
            Load += UserRequestAccepted_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox phone;
        private Label label4;
        private TextBox rating;
        private TextBox name;
    }
}