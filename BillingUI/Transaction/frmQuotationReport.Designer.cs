namespace AC.Billing.UI.Transaction
{
    partial class frmQuotationReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PrintGrid = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseExpectedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrint = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(495, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 23);
            this.label14.TabIndex = 136;
            this.label14.Text = "Quotation Report";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.PrintGrid);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(31, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1088, 348);
            this.panel3.TabIndex = 133;
            // 
            // PrintGrid
            // 
            this.PrintGrid.AllowUserToAddRows = false;
            this.PrintGrid.AllowUserToDeleteRows = false;
            this.PrintGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintGrid.Location = new System.Drawing.Point(15, 63);
            this.PrintGrid.Name = "PrintGrid";
            this.PrintGrid.Size = new System.Drawing.Size(240, 150);
            this.PrintGrid.TabIndex = 139;
            this.PrintGrid.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.QuotationDate,
            this.PurchaseExpectedBy,
            this.PaymentMode,
            this.TaxAmount,
            this.DiscountAmount,
            this.TotalAmount});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1078, 322);
            this.dataGridView1.TabIndex = 130;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "CustomerName";
            this.Customer.HeaderText = "Customer Name";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 300;
            // 
            // QuotationDate
            // 
            this.QuotationDate.DataPropertyName = "QuotationDate";
            this.QuotationDate.HeaderText = "Quotation Date";
            this.QuotationDate.Name = "QuotationDate";
            this.QuotationDate.ReadOnly = true;
            this.QuotationDate.Width = 110;
            // 
            // PurchaseExpectedBy
            // 
            this.PurchaseExpectedBy.DataPropertyName = "PurchaseExpectedBy";
            this.PurchaseExpectedBy.HeaderText = "Purchase Expected By";
            this.PurchaseExpectedBy.Name = "PurchaseExpectedBy";
            this.PurchaseExpectedBy.ReadOnly = true;
            this.PurchaseExpectedBy.Width = 150;
            // 
            // PaymentMode
            // 
            this.PaymentMode.DataPropertyName = "PaymentMode";
            this.PaymentMode.HeaderText = "Payment Mode";
            this.PaymentMode.Name = "PaymentMode";
            this.PaymentMode.ReadOnly = true;
            this.PaymentMode.Width = 130;
            // 
            // TaxAmount
            // 
            this.TaxAmount.DataPropertyName = "TaxAmount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.TaxAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.TaxAmount.HeaderText = "Tax Amount";
            this.TaxAmount.Name = "TaxAmount";
            this.TaxAmount.ReadOnly = true;
            this.TaxAmount.Width = 110;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.DataPropertyName = "DiscountAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.DiscountAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.DiscountAmount.HeaderText = "Disc. Amount";
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.ReadOnly = true;
            this.DiscountAmount.Width = 110;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.TotalAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 120;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnPrintPreview);
            this.panel2.Location = new System.Drawing.Point(31, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 53);
            this.panel2.TabIndex = 132;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(598, 14);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 66;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Location = new System.Drawing.Point(386, 14);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 48;
            this.btnView.Text = "View Report";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnPrintPreview.FlatAppearance.BorderSize = 0;
            this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreview.Location = new System.Drawing.Point(485, 14);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(90, 23);
            this.btnPrintPreview.TabIndex = 67;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 88);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEndDate.Location = new System.Drawing.Point(663, 38);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(97, 20);
            this.txtEndDate.TabIndex = 7;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStartDate.Location = new System.Drawing.Point(376, 38);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(99, 20);
            this.txtStartDate.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(285, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Quotation From :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(582, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Quotation To :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 53);
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(3, 607);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(0, 13);
            this.lblPrint.TabIndex = 137;
            // 
            // frmQuotationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1144, 632);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuotationReport";
            this.Text = "Quotation Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuotationReport_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrintGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuotationDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseExpectedBy;
		private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMode;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridView PrintGrid;
        private System.Windows.Forms.Label lblPrint;
	}
}