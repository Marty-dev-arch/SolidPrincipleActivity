namespace SolidPrincipleActivity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtCustomerEmail = new TextBox();
            label1 = new Label();
            dgvItems = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            label2 = new Label();
            cmbDiscountType = new ComboBox();
            label3 = new Label();
            btnCalculate = new Button();
            btnSaveOrder = new Button();
            btnEmailInvoice = new Button();
            btnPrint = new Button();
            label4 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.BackColor = Color.White;
            txtCustomerEmail.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerEmail.Font = new Font("Segoe UI", 10F);
            txtCustomerEmail.Location = new Point(190, 76);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(470, 25);
            txtCustomerEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(55, 65, 81);
            label1.Location = new Point(70, 81);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 1;
            label1.Text = "Customer Email:";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvItems.ColumnHeadersHeight = 34;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Qty });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle4;
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.GridColor = Color.FromArgb(229, 231, 235);
            dgvItems.Location = new Point(70, 124);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowTemplate.Height = 30;
            dgvItems.Size = new Size(700, 245);
            dgvItems.TabIndex = 2;
            // 
            // Product
            // 
            Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Product.FillWeight = 55F;
            Product.HeaderText = "Product";
            Product.Name = "Product";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.FillWeight = 25F;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Qty
            // 
            Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Qty.FillWeight = 20F;
            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(55, 65, 81);
            label2.Location = new Point(70, 102);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 3;
            label2.Text = "Items:";
            // 
            // cmbDiscountType
            // 
            cmbDiscountType.BackColor = Color.White;
            cmbDiscountType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiscountType.Font = new Font("Segoe UI", 9.5F);
            cmbDiscountType.FormattingEnabled = true;
            cmbDiscountType.Items.AddRange(new object[] { "None", "Student", "Senior", "BlackFriday", "FreeShippingDiscount" });
            cmbDiscountType.Location = new Point(190, 393);
            cmbDiscountType.Name = "cmbDiscountType";
            cmbDiscountType.Size = new Size(180, 25);
            cmbDiscountType.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(55, 65, 81);
            label3.Location = new Point(70, 398);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 5;
            label3.Text = "Discount Type:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(37, 99, 235);
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(70, 480);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(130, 36);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.BackColor = Color.FromArgb(16, 185, 129);
            btnSaveOrder.FlatAppearance.BorderSize = 0;
            btnSaveOrder.FlatStyle = FlatStyle.Flat;
            btnSaveOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveOrder.ForeColor = Color.White;
            btnSaveOrder.Location = new Point(210, 480);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(130, 36);
            btnSaveOrder.TabIndex = 7;
            btnSaveOrder.Text = "Save order";
            btnSaveOrder.UseVisualStyleBackColor = false;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnEmailInvoice
            // 
            btnEmailInvoice.BackColor = Color.FromArgb(245, 158, 11);
            btnEmailInvoice.FlatAppearance.BorderSize = 0;
            btnEmailInvoice.FlatStyle = FlatStyle.Flat;
            btnEmailInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmailInvoice.ForeColor = Color.White;
            btnEmailInvoice.Location = new Point(350, 480);
            btnEmailInvoice.Name = "btnEmailInvoice";
            btnEmailInvoice.Size = new Size(130, 36);
            btnEmailInvoice.TabIndex = 8;
            btnEmailInvoice.Text = "Email Invoice";
            btnEmailInvoice.UseVisualStyleBackColor = false;
            btnEmailInvoice.Click += btnEmailInvoice_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(107, 114, 128);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(490, 480);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(130, 36);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(55, 65, 81);
            label4.Location = new Point(520, 400);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 10;
            label4.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(37, 99, 235);
            lblTotal.Location = new Point(575, 392);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(26, 30);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(840, 570);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(btnPrint);
            Controls.Add(btnEmailInvoice);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnCalculate);
            Controls.Add(label3);
            Controls.Add(cmbDiscountType);
            Controls.Add(label2);
            Controls.Add(dgvItems);
            Controls.Add(label1);
            Controls.Add(txtCustomerEmail);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerEmail;
        private Label label1;
        private DataGridView dgvItems;
        private Label label2;
        private ComboBox cmbDiscountType;
        private Label label3;
        private Button btnCalculate;
        private Button btnSaveOrder;
        private Button btnEmailInvoice;
        private Button btnPrint;
        private Label label4;
        private Label lblTotal;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qty;
    }
}
