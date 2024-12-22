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
            dateTimePicker1 = new DateTimePicker();
            endate = new Label();
            startdate = new Label();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // chooseservice
            // 
            chooseservice.ForeColor = Color.FromArgb(41, 128, 185);
            chooseservice.FormattingEnabled = true;
            chooseservice.Items.AddRange(new object[] { "cleaning", "plumbing", "electricians ", "babysitting" });
            chooseservice.Location = new Point(258, 12);
            chooseservice.Name = "chooseservice";
            chooseservice.Size = new Size(274, 28);
            chooseservice.TabIndex = 0;
            chooseservice.Text = "what service do you need ";
            chooseservice.SelectedIndexChanged += chooseservice_SelectedIndexChanged;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(41, 128, 185);
            back.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            back.Location = new Point(693, 13);
            back.Name = "back";
            back.Size = new Size(106, 35);
            back.TabIndex = 1;
            back.Text = "back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 48);
            label1.TabIndex = 2;
            label1.Text = "easily find and book servicies";
            // 
            // makrequest
            // 
            makrequest.BackColor = Color.FromArgb(41, 128, 185);
            makrequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makrequest.Location = new Point(258, 343);
            makrequest.Name = "makrequest";
            makrequest.Size = new Size(274, 47);
            makrequest.TabIndex = 4;
            makrequest.Text = "confirm request";
            makrequest.UseVisualStyleBackColor = false;
            makrequest.Click += makrequest_Click;
            // 
            // description
            // 
            description.BackColor = SystemColors.InactiveCaption;
            description.Location = new Point(258, 108);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(274, 157);
            description.TabIndex = 6;
            description.Text = "describe your requirment";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(195, 156);
            label2.TabIndex = 7;
            label2.Text = "choose the best match based on your prefernces and budget";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(549, 154);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // endate
            // 
            endate.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endate.ForeColor = Color.FromArgb(41, 128, 185);
            endate.Location = new Point(626, 197);
            endate.Name = "endate";
            endate.Size = new Size(110, 29);
            endate.TabIndex = 9;
            endate.Text = "end date";
            // 
            // startdate
            // 
            startdate.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startdate.ForeColor = Color.FromArgb(41, 128, 185);
            startdate.Location = new Point(617, 108);
            startdate.Name = "startdate";
            startdate.Size = new Size(110, 27);
            startdate.TabIndex = 10;
            startdate.Text = "start date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(549, 238);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // UserMakingRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Proj_pic;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker2);
            Controls.Add(startdate);
            Controls.Add(endate);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(description);
            Controls.Add(makrequest);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(chooseservice);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserMakingRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMakingRequest";
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
        private DateTimePicker dateTimePicker1;
        private Label endate;
        private Label startdate;
        private DateTimePicker dateTimePicker2;
    }
}