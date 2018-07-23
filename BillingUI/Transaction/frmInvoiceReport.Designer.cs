

namespace AC.Billing.UI.Transaction
{
    partial class frmInvoiceReport
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
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentExpectedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label14.Location = new System.Drawing.Point(497, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 23);
            this.label14.TabIndex = 135;
            this.label14.Text = "Invoice Report";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.PrintGrid);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(28, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1086, 339);
            this.panel3.TabIndex = 130;
            // 
            // PrintGrid
            // 
            this.PrintGrid.AllowUserToAddRows = false;
            this.PrintGrid.AllowUserToDeleteRows = false;
            this.PrintGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintGrid.Location = new System.Drawing.Point(16, 86);
            this.PrintGrid.Name = "PrintGrid";
            this.PrintGrid.Size = new System.Drawing.Size(240, 150);
            this.PrintGrid.TabIndex = 131;
            this.PrintGrid.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.InvoiceNo,
            this.Email,
            this.IsPaid,
            this.InvoiceDate,
            this.PaymentExpectedBy,
            this.TaxAmount,
            this.DiscountAmount,
            this.TotalAmount});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1076, 318);
            this.dataGridView1.TabIndex = 130;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "CustomerName";
            this.Customer.HeaderText = "Customer Name";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 150;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.DataPropertyName = "InvoiceNo";
            this.InvoiceNo.HeaderText = "Invoice No.";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 120;
            // 
            // IsPaid
            // 
            this.IsPaid.DataPropertyName = "IsPaid";
            this.IsPaid.HeaderText = "Is Paid";
            this.IsPaid.Name = "IsPaid";
            this.IsPaid.ReadOnly = true;
            this.IsPaid.Width = 80;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.DataPropertyName = "InvoiceDate";
            this.InvoiceDate.HeaderText = "Invoice Date";
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.ReadOnly = true;
            this.InvoiceDate.Width = 110;
            // 
            // PaymentExpectedBy
            // 
            this.PaymentExpectedBy.DataPropertyName = "PaymentExpectedBy";
            this.PaymentExpectedBy.HeaderText = "Payment Expctd On";
            this.PaymentExpectedBy.Name = "PaymentExpectedBy";
            this.PaymentExpectedBy.ReadOnly = true;
            this.PaymentExpectedBy.Width = 130;
            // 
            // TaxAmount
            // 
            this.TaxAmount.DataPropertyName = "TaxAmount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.TaxAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.TaxAmount.HeaderText = "Tax Amount";
            this.TaxAmount.Name = "TaxAmount";
            this.TaxAmount.ReadOnly = true;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.DataPropertyName = "DiscountAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.DiscountAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.DiscountAmount.HeaderText = "Discount Amount";
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.ReadOnly = true;
            this.DiscountAmount.Width = 120;
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
            this.panel2.Location = new System.Drawing.Point(28, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 53);
            this.panel2.TabIndex = 128;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(601, 12);
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
            this.btnView.Location = new System.Drawing.Point(398, 12);
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
            this.btnPrintPreview.Location = new System.Drawing.Point(491, 12);
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
            this.groupBox1.Location = new System.Drawing.Point(28, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 88);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Report";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEndDate.Location = new System.Drawing.Point(684, 31);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(118, 20);
            this.txtEndDate.TabIndex = 7;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStartDate.Location = new System.Drawing.Point(388, 31);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(118, 20);
            this.txtStartDate.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(271, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Invoice Date  From :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(570, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Invoice Date To :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 53);
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(13, 607);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(0, 13);
            this.lblPrint.TabIndex = 136;
            // 
            // frmInvoiceReport
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
            this.Name = "frmInvoiceReport";
            this.Text = "Invoice Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvoiceReport_Load);
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn IsPaid;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn PaymentExpectedBy;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridView PrintGrid;
        private System.Windows.Forms.Label lblPrint;
	}
}