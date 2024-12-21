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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // chooseservice
            // 
            chooseservice.ForeColor = Color.FromArgb(41, 128, 185);
            chooseservice.FormattingEnabled = true;
            chooseservice.Items.AddRange(new object[] { "cleaning", "plumbing", "electricians ", "babysitting" });
            chooseservice.Location = new Point(299, 13);
            chooseservice.Name = "chooseservice";
            chooseservice.Size = new Size(294, 28);
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
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(281, 34);
            label1.TabIndex = 2;
            label1.Text = "easily find and book servicies";
            // 
            // makrequest
            // 
            makrequest.BackColor = Color.FromArgb(41, 128, 185);
            makrequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makrequest.Location = new Point(351, 324);
            makrequest.Name = "makrequest";
            makrequest.Size = new Size(200, 47);
            makrequest.TabIndex = 4;
            makrequest.Text = "confirm request";
            makrequest.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 5;
            // 
            // UserMakingRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Proj_pic;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox chooseservice;
        private HelpProvider helpProvider1;
        private Button back;
        private Label label1;
        private Button makrequest;
        private DataGridView dataGridView1;
    }
}