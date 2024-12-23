namespace TalabatServices
{
    partial class WorkerHomePage
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
            WorkerName_lbl = new Label();
            WorkerRating_lbl = new Label();
            dataGridView_Orders = new DataGridView();
            District_cb = new ComboBox();
            District_lbl = new Label();
            setting = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Orders).BeginInit();
            SuspendLayout();
            // 
            // WorkerName_lbl
            // 
            WorkerName_lbl.AutoSize = true;
            WorkerName_lbl.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            WorkerName_lbl.ForeColor = Color.FromArgb(41, 128, 185);
            WorkerName_lbl.Location = new Point(32, 31);
            WorkerName_lbl.Margin = new Padding(2, 0, 2, 0);
            WorkerName_lbl.Name = "WorkerName_lbl";
            WorkerName_lbl.Size = new Size(220, 38);
            WorkerName_lbl.TabIndex = 7;
            WorkerName_lbl.Text = "WorkerName";
            // 
            // WorkerRating_lbl
            // 
            WorkerRating_lbl.AutoSize = true;
            WorkerRating_lbl.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            WorkerRating_lbl.ForeColor = Color.FromArgb(41, 128, 185);
            WorkerRating_lbl.Location = new Point(340, 31);
            WorkerRating_lbl.Margin = new Padding(2, 0, 2, 0);
            WorkerRating_lbl.Name = "WorkerRating_lbl";
            WorkerRating_lbl.Size = new Size(117, 38);
            WorkerRating_lbl.TabIndex = 8;
            WorkerRating_lbl.Text = "Rating";
            // 
            // dataGridView_Orders
            // 
            dataGridView_Orders.AllowUserToOrderColumns = true;
            dataGridView_Orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Orders.Location = new Point(14, 248);
            dataGridView_Orders.Margin = new Padding(2);
            dataGridView_Orders.Name = "dataGridView_Orders";
            dataGridView_Orders.RowHeadersWidth = 62;
            dataGridView_Orders.Size = new Size(1098, 422);
            dataGridView_Orders.TabIndex = 9;
            dataGridView_Orders.CellContentClick += dataGridViewOrders_CellContentClick;
            // 
            // District_cb
            // 
            District_cb.BackColor = SystemColors.ButtonFace;
            District_cb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            District_cb.FormattingEnabled = true;
            District_cb.Location = new Point(246, 129);
            District_cb.Margin = new Padding(2);
            District_cb.Name = "District_cb";
            District_cb.Size = new Size(245, 40);
            District_cb.TabIndex = 10;
            District_cb.SelectedIndexChanged += District_cb_SelectedIndexChanged;
            // 
            // District_lbl
            // 
            District_lbl.AutoSize = true;
            District_lbl.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            District_lbl.ForeColor = Color.FromArgb(41, 128, 185);
            District_lbl.Location = new Point(32, 129);
            District_lbl.Margin = new Padding(2, 0, 2, 0);
            District_lbl.Name = "District_lbl";
            District_lbl.Size = new Size(146, 38);
            District_lbl.TabIndex = 11;
            District_lbl.Text = "District: ";
            // 
            // setting
            // 
            setting.BackColor = Color.FromArgb(41, 128, 185);
            setting.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            setting.ForeColor = Color.White;
            setting.Location = new Point(1002, 0);
            setting.Margin = new Padding(4, 4, 4, 4);
            setting.Name = "setting";
            setting.Size = new Size(118, 72);
            setting.TabIndex = 12;
            setting.Text = "Setting";
            setting.UseVisualStyleBackColor = false;
            setting.Click += setting_Click;
            // 
            // WorkerHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1124, 681);
            Controls.Add(setting);
            Controls.Add(District_lbl);
            Controls.Add(District_cb);
            Controls.Add(dataGridView_Orders);
            Controls.Add(WorkerRating_lbl);
            Controls.Add(WorkerName_lbl);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "WorkerHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += WorkerHomePage_FormClosed;
            Load += WorkerHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Orders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WorkerName_lbl;
        private Label WorkerRating_lbl;
        private DataGridView dataGridView_Orders;
        private ComboBox District_cb;
        private Label District_lbl;
        private Button setting;
    }
}