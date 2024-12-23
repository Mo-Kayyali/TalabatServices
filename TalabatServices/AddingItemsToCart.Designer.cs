namespace TalabatServices
{
    partial class AddingItemsToCart
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
            dataGridView1 = new DataGridView();
            ItemName_tb = new TextBox();
            Quantity_tb = new TextBox();
            Price_tb = new TextBox();
            Name_lbl = new Label();
            Quantity = new Label();
            Price = new Label();
            SubmitToDB_Btn = new Button();
            AddToGrid_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(524, 14);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(730, 596);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ItemName_tb
            // 
            ItemName_tb.BackColor = SystemColors.ButtonFace;
            ItemName_tb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ItemName_tb.Location = new Point(250, 72);
            ItemName_tb.Margin = new Padding(2);
            ItemName_tb.MaxLength = 50;
            ItemName_tb.Name = "ItemName_tb";
            ItemName_tb.Size = new Size(252, 39);
            ItemName_tb.TabIndex = 1;
            // 
            // Quantity_tb
            // 
            Quantity_tb.BackColor = SystemColors.ButtonFace;
            Quantity_tb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Quantity_tb.Location = new Point(250, 196);
            Quantity_tb.Margin = new Padding(2);
            Quantity_tb.MaxLength = 6;
            Quantity_tb.Name = "Quantity_tb";
            Quantity_tb.Size = new Size(252, 39);
            Quantity_tb.TabIndex = 2;
            // 
            // Price_tb
            // 
            Price_tb.BackColor = SystemColors.ButtonFace;
            Price_tb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Price_tb.Location = new Point(250, 320);
            Price_tb.Margin = new Padding(2);
            Price_tb.MaxLength = 7;
            Price_tb.Name = "Price_tb";
            Price_tb.Size = new Size(252, 39);
            Price_tb.TabIndex = 3;
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            Name_lbl.ForeColor = Color.FromArgb(41, 128, 185);
            Name_lbl.Location = new Point(21, 72);
            Name_lbl.Margin = new Padding(2, 0, 2, 0);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(199, 39);
            Name_lbl.TabIndex = 6;
            Name_lbl.Text = "Item name";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            Quantity.ForeColor = Color.FromArgb(41, 128, 185);
            Quantity.Location = new Point(38, 196);
            Quantity.Margin = new Padding(2, 0, 2, 0);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(183, 39);
            Quantity.TabIndex = 7;
            Quantity.Text = "Quantity";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            Price.ForeColor = Color.FromArgb(41, 128, 185);
            Price.Location = new Point(9, 320);
            Price.Margin = new Padding(2, 0, 2, 0);
            Price.Name = "Price";
            Price.Size = new Size(211, 39);
            Price.TabIndex = 8;
            Price.Text = "Price/Item";
            // 
            // SubmitToDB_Btn
            // 
            SubmitToDB_Btn.BackColor = Color.FromArgb(41, 128, 185);
            SubmitToDB_Btn.FlatStyle = FlatStyle.Flat;
            SubmitToDB_Btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitToDB_Btn.ForeColor = Color.White;
            SubmitToDB_Btn.Location = new Point(179, 538);
            SubmitToDB_Btn.Margin = new Padding(4, 4, 4, 4);
            SubmitToDB_Btn.Name = "SubmitToDB_Btn";
            SubmitToDB_Btn.Size = new Size(144, 72);
            SubmitToDB_Btn.TabIndex = 19;
            SubmitToDB_Btn.Text = "Finish!";
            SubmitToDB_Btn.UseVisualStyleBackColor = false;
            SubmitToDB_Btn.Click += SubmitToDB_Btn_Click;
            // 
            // AddToGrid_Btn
            // 
            AddToGrid_Btn.BackColor = Color.FromArgb(41, 128, 185);
            AddToGrid_Btn.FlatStyle = FlatStyle.Flat;
            AddToGrid_Btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddToGrid_Btn.ForeColor = Color.White;
            AddToGrid_Btn.Location = new Point(200, 416);
            AddToGrid_Btn.Margin = new Padding(4, 4, 4, 4);
            AddToGrid_Btn.Name = "AddToGrid_Btn";
            AddToGrid_Btn.Size = new Size(108, 52);
            AddToGrid_Btn.TabIndex = 20;
            AddToGrid_Btn.Text = "Add";
            AddToGrid_Btn.UseVisualStyleBackColor = false;
            AddToGrid_Btn.Click += AddToGrid_Btn_Click;
            // 
            // AddingItemsToCart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1268, 625);
            Controls.Add(AddToGrid_Btn);
            Controls.Add(SubmitToDB_Btn);
            Controls.Add(Price);
            Controls.Add(Quantity);
            Controls.Add(Name_lbl);
            Controls.Add(Price_tb);
            Controls.Add(Quantity_tb);
            Controls.Add(ItemName_tb);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "AddingItemsToCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddingItemsToCart";
            FormClosed += AddingItemsToCart_FormClosed;
            Load += AddingItemsToCart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox ItemName_tb;
        private TextBox Quantity_tb;
        private TextBox Price_tb;
        private Label Name_lbl;
        private Label Quantity;
        private Label Price;
        private Button SubmitToDB_Btn;
        private Button AddToGrid_Btn;
    }
}