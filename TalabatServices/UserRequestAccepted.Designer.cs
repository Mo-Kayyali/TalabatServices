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
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(18, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 33);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(177, 50);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 34);
            textBox1.TabIndex = 1;
            // 
            // UserRequestAccepted
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            //BackgroundImage = Properties.Resources.Proj_pic;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1200, 630);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UserRequestAccepted";
            Text = "UserRequestAccepted";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
    }
}