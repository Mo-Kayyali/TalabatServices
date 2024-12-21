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
            ((System.ComponentModel.ISupportInitialize)dataGridView_Orders).BeginInit();
            SuspendLayout();
            // 
            // WorkerName_lbl
            // 
            WorkerName_lbl.AutoSize = true;
            WorkerName_lbl.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            WorkerName_lbl.ForeColor = Color.FromArgb(41, 128, 185);
            WorkerName_lbl.Location = new Point(33, 31);
            WorkerName_lbl.Name = "WorkerName_lbl";
            WorkerName_lbl.Size = new Size(251, 39);
            WorkerName_lbl.TabIndex = 7;
            WorkerName_lbl.Text = "WorkerName";
            // 
            // WorkerRating_lbl
            // 
            WorkerRating_lbl.AutoSize = true;
            WorkerRating_lbl.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            WorkerRating_lbl.ForeColor = Color.FromArgb(41, 128, 185);
            WorkerRating_lbl.Location = new Point(340, 31);
            WorkerRating_lbl.Name = "WorkerRating_lbl";
            WorkerRating_lbl.Size = new Size(141, 39);
            WorkerRating_lbl.TabIndex = 8;
            WorkerRating_lbl.Text = "Rating";
            // 
            // dataGridView_Orders
            // 
            dataGridView_Orders.AllowUserToOrderColumns = true;
            dataGridView_Orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Orders.Location = new Point(488, 247);
            dataGridView_Orders.Name = "dataGridView_Orders";
            dataGridView_Orders.RowHeadersWidth = 62;
            dataGridView_Orders.Size = new Size(624, 422);
            dataGridView_Orders.TabIndex = 9;
            // 
            // District_cb
            // 
            District_cb.FormattingEnabled = true;
            District_cb.Location = new Point(869, 189);
            District_cb.Name = "District_cb";
            District_cb.Size = new Size(182, 33);
            District_cb.TabIndex = 10;
            // 
            // District_lbl
            // 
            District_lbl.AutoSize = true;
            District_lbl.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            District_lbl.ForeColor = Color.FromArgb(41, 128, 185);
            District_lbl.Location = new Point(549, 189);
            District_lbl.Name = "District_lbl";
            District_lbl.Size = new Size(193, 39);
            District_lbl.TabIndex = 11;
            District_lbl.Text = "District: ";
            // 
            // WorkerHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;

//            BackgroundImage = Properties.Resources.Proj_pic;

            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1124, 681);
            Controls.Add(District_lbl);
            Controls.Add(District_cb);
            Controls.Add(dataGridView_Orders);
            Controls.Add(WorkerRating_lbl);
            Controls.Add(WorkerName_lbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "WorkerHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkerHomePage";
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
    }
}