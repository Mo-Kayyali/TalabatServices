namespace TalabatServices
{
    partial class UserMakingRequest
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
            chooseservice = new ComboBox();
            helpProvider1 = new HelpProvider();
            back = new Button();
            label1 = new Label();
            makrequest = new Button();
            description = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // chooseservice
            // 
            chooseservice.ForeColor = SystemColors.WindowText;
            chooseservice.FormattingEnabled = true;
            chooseservice.Location = new Point(322, 10);
            chooseservice.Margin = new Padding(4, 4, 4, 4);
            chooseservice.Name = "chooseservice";
            chooseservice.Size = new Size(342, 33);
            chooseservice.TabIndex = 0;
            chooseservice.Text = "Choose The Service You Want ...";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(41, 128, 185);
            back.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.ForeColor = Color.White;
            back.Location = new Point(848, 2);
            back.Margin = new Padding(4, 4, 4, 4);
            back.Name = "back";
            back.Size = new Size(150, 85);
            back.TabIndex = 1;
            back.Text = "Back To Home Page";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(4, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(311, 62);
            label1.TabIndex = 2;
            label1.Text = "easily find and book servicies";
            // 
            // makrequest
            // 
            makrequest.BackColor = Color.FromArgb(41, 128, 185);
            makrequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makrequest.ForeColor = Color.White;
            makrequest.Location = new Point(249, 432);
            makrequest.Margin = new Padding(4, 4, 4, 4);
            makrequest.Name = "makrequest";
            makrequest.Size = new Size(470, 71);
            makrequest.TabIndex = 4;
            makrequest.Text = "Confirm Request";
            makrequest.UseVisualStyleBackColor = false;
            makrequest.Click += makrequest_Click;
            // 
            // description
            // 
            description.BackColor = SystemColors.InactiveCaption;
            description.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            description.Location = new Point(322, 136);
            description.Margin = new Padding(4, 4, 4, 4);
            description.MaxLength = 500;
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(662, 284);
            description.TabIndex = 2;
            description.Text = "Description ...";
            // 
            // label2
            // 
            label2.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(4, 136);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(311, 225);
            label2.TabIndex = 7;
            label2.Text = "Descripe Your Problem (Important) In not more than 500 Letters";
            // 
            // UserMakingRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Proj_pic;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1000, 519);
            Controls.Add(label2);
            Controls.Add(description);
            Controls.Add(makrequest);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(chooseservice);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "UserMakingRequest";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += UserMakingRequest_FormClosed;
            Load += UserMakingRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox chooseservice;
        private HelpProvider helpProvider1;
        private Button back;
        private Label label1;
        private Button makrequest;
        private TextBox description;
        private Label label2;
    }
}