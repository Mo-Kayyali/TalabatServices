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
            dataGridView1.Location = new Point(508, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(730, 466);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ItemName_tb
            // 
            ItemName_tb.Location = new Point(293, 81);
            ItemName_tb.Name = "ItemName_tb";
            ItemName_tb.Size = new Size(150, 31);
            ItemName_tb.TabIndex = 3;
            // 
            // Quantity_tb
            // 
            Quantity_tb.Location = new Point(293, 206);
            Quantity_tb.Name = "Quantity_tb";
            Quantity_tb.Size = new Size(150, 31);
            Quantity_tb.TabIndex = 4;
            // 
            // Price_tb
            // 
            Price_tb.Location = new Point(293, 320);
            Price_tb.Name = "Price_tb";
            Price_tb.Size = new Size(150, 31);
            Price_tb.TabIndex = 5;
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Font = new Font("Stencil", 16.2F, FontStyle.Bold);
            Name_lbl.ForeColor = Color.FromArgb(41, 128, 185);
            Name_lbl.Location = new Point(31, 73);
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
            Quantity.Location = new Point(31, 206);
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
            Price.Location = new Point(31, 320);
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
            SubmitToDB_Btn.Location = new Point(1008, 560);
            SubmitToDB_Btn.Margin = new Padding(4);
            SubmitToDB_Btn.Name = "SubmitToDB_Btn";
            SubmitToDB_Btn.Size = new Size(144, 72);
            SubmitToDB_Btn.TabIndex = 19;
            SubmitToDB_Btn.Text = "Finish!";
            SubmitToDB_Btn.UseVisualStyleBackColor = false;
            // 
            // AddToGrid_Btn
            // 
            AddToGrid_Btn.BackColor = Color.FromArgb(41, 128, 185);
            AddToGrid_Btn.FlatStyle = FlatStyle.Flat;
            AddToGrid_Btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddToGrid_Btn.ForeColor = Color.White;
            AddToGrid_Btn.Location = new Point(204, 439);
            AddToGrid_Btn.Margin = new Padding(4);
            AddToGrid_Btn.Name = "AddToGrid_Btn";
            AddToGrid_Btn.Size = new Size(108, 53);
            AddToGrid_Btn.TabIndex = 20;
            AddToGrid_Btn.Text = "Add";
            AddToGrid_Btn.UseVisualStyleBackColor = false;
            // 
            // AddingItemsToCart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1268, 741);
            Controls.Add(AddToGrid_Btn);
            Controls.Add(SubmitToDB_Btn);
            Controls.Add(Price);
            Controls.Add(Quantity);
            Controls.Add(Name_lbl);
            Controls.Add(Price_tb);
            Controls.Add(Quantity_tb);
            Controls.Add(ItemName_tb);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AddingItemsToCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddingItemsToCart";
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