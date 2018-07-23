namespace AC.Billing.UI.Transaction
{
    partial class frmInvoice
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.PrintGrid = new System.Windows.Forms.DataGridView();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnPrintPreview = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnDeleteRow = new System.Windows.Forms.Button();
			this.btnAddRow = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.InvoiceID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsOnCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PaytDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EditParent = new System.Windows.Forms.DataGridViewButtonColumn();
			this.DeleteParent = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbWithoutGST = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdBusiness = new System.Windows.Forms.RadioButton();
			this.rdIndividual = new System.Windows.Forms.RadioButton();
			this.txtGSTIN = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.chkSameAddress = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtInvoiceNo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtShippingAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBillingAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtInvoiceDate = new System.Windows.Forms.DateTimePicker();
			this.cmbIsOnCredit = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbIsPaid = new System.Windows.Forms.ComboBox();
			this.txtContactNumber = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtPaymentExDate = new System.Windows.Forms.DateTimePicker();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.TxtWebSite = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.IsDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.InvoiceItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InvoiceId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TaxID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.HSN_SAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Size = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.RateperUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TaxAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiscountAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PrintGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(532, 19);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(73, 23);
			this.label12.TabIndex = 130;
			this.label12.Text = "Invoice";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.PrintGrid);
			this.panel1.Controls.Add(this.txtTotal);
			this.panel1.Controls.Add(this.lblTotal);
			this.panel1.Controls.Add(this.dataGridView2);
			this.panel1.Location = new System.Drawing.Point(26, 228);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1088, 208);
			this.panel1.TabIndex = 129;
			// 
			// PrintGrid
			// 
			this.PrintGrid.AllowUserToAddRows = false;
			this.PrintGrid.AllowUserToDeleteRows = false;
			this.PrintGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PrintGrid.Location = new System.Drawing.Point(24, 175);
			this.PrintGrid.Name = "PrintGrid";
			this.PrintGrid.Size = new System.Drawing.Size(240, 150);
			this.PrintGrid.TabIndex = 13;
			this.PrintGrid.Visible = false;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(936, 181);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(91, 20);
			this.txtTotal.TabIndex = 12;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.ForeColor = System.Drawing.Color.White;
			this.lblTotal.Location = new System.Drawing.Point(855, 184);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(69, 13);
			this.lblTotal.TabIndex = 11;
			this.lblTotal.Text = "Grand Total :";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToResizeColumns = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsDelete,
            this.InvoiceItemID,
            this.InvoiceId1,
            this.ProductID,
            this.TaxID,
            this.SizeID,
            this.Product,
            this.HSN_SAC,
            this.Make,
            this.Quantity,
            this.Unit,
            this.Size,
            this.RateperUnit,
            this.Tax,
            this.TaxAmt,
            this.Discount,
            this.DiscountAmt,
            this.TotalAmt,
            this.Remark,
            this.UnitID});
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(1078, 175);
			this.dataGridView2.TabIndex = 10;
			this.dataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
			this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnPrintPreview);
			this.panel2.Controls.Add(this.btnPrint);
			this.panel2.Controls.Add(this.btnDeleteRow);
			this.panel2.Controls.Add(this.btnAddRow);
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Location = new System.Drawing.Point(26, 442);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1088, 43);
			this.panel2.TabIndex = 96;
			// 
			// btnPrintPreview
			// 
			this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnPrintPreview.FlatAppearance.BorderSize = 0;
			this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrintPreview.Location = new System.Drawing.Point(626, 10);
			this.btnPrintPreview.Name = "btnPrintPreview";
			this.btnPrintPreview.Size = new System.Drawing.Size(90, 23);
			this.btnPrintPreview.TabIndex = 16;
			this.btnPrintPreview.Text = "Print Preview";
			this.btnPrintPreview.UseVisualStyleBackColor = false;
			this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnPrint.FlatAppearance.BorderSize = 0;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Location = new System.Drawing.Point(722, 10);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 15;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnDeleteRow
			// 
			this.btnDeleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnDeleteRow.FlatAppearance.BorderSize = 0;
			this.btnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteRow.Location = new System.Drawing.Point(543, 10);
			this.btnDeleteRow.Name = "btnDeleteRow";
			this.btnDeleteRow.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteRow.TabIndex = 14;
			this.btnDeleteRow.Text = "Delete Row";
			this.btnDeleteRow.UseVisualStyleBackColor = false;
			this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
			// 
			// btnAddRow
			// 
			this.btnAddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnAddRow.FlatAppearance.BorderSize = 0;
			this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddRow.Location = new System.Drawing.Point(462, 10);
			this.btnAddRow.Name = "btnAddRow";
			this.btnAddRow.Size = new System.Drawing.Size(75, 23);
			this.btnAddRow.TabIndex = 13;
			this.btnAddRow.Text = "Add Row";
			this.btnAddRow.UseVisualStyleBackColor = false;
			this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(381, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(300, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Location = new System.Drawing.Point(26, 491);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1088, 138);
			this.panel3.TabIndex = 128;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID2,
            this.Customer,
            this.ContactNumber,
            this.Website,
            this.IsPaid,
            this.IsOnCredit,
            this.InvoiceDate,
            this.PaytDate,
            this.Remarks,
            this.EditParent,
            this.DeleteParent});
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1078, 127);
			this.dataGridView1.TabIndex = 13;
			// 
			// InvoiceID2
			// 
			this.InvoiceID2.DataPropertyName = "InvoiceID";
			this.InvoiceID2.HeaderText = "InvoiceID";
			this.InvoiceID2.Name = "InvoiceID2";
			this.InvoiceID2.ReadOnly = true;
			this.InvoiceID2.Visible = false;
			// 
			// Customer
			// 
			this.Customer.DataPropertyName = "CustomerName";
			this.Customer.HeaderText = "Customer Name";
			this.Customer.Name = "Customer";
			this.Customer.ReadOnly = true;
			this.Customer.Width = 200;
			// 
			// ContactNumber
			// 
			this.ContactNumber.DataPropertyName = "ContactNumber";
			this.ContactNumber.HeaderText = "Mobile No.";
			this.ContactNumber.Name = "ContactNumber";
			this.ContactNumber.ReadOnly = true;
			this.ContactNumber.Width = 90;
			// 
			// Website
			// 
			this.Website.DataPropertyName = "Website";
			this.Website.HeaderText = "Website";
			this.Website.Name = "Website";
			this.Website.ReadOnly = true;
			this.Website.Width = 110;
			// 
			// IsPaid
			// 
			this.IsPaid.DataPropertyName = "IsPaid";
			this.IsPaid.HeaderText = "Is Paid";
			this.IsPaid.Name = "IsPaid";
			this.IsPaid.ReadOnly = true;
			this.IsPaid.Width = 70;
			// 
			// IsOnCredit
			// 
			this.IsOnCredit.DataPropertyName = "IsOnCredit";
			this.IsOnCredit.HeaderText = "Is On Credit";
			this.IsOnCredit.Name = "IsOnCredit";
			this.IsOnCredit.ReadOnly = true;
			// 
			// InvoiceDate
			// 
			this.InvoiceDate.DataPropertyName = "InvoiceDate";
			this.InvoiceDate.HeaderText = "Invoice Date";
			this.InvoiceDate.Name = "InvoiceDate";
			this.InvoiceDate.ReadOnly = true;
			// 
			// PaytDate
			// 
			this.PaytDate.DataPropertyName = "PaymentExpectedBy";
			this.PaytDate.HeaderText = "Pay Date";
			this.PaytDate.Name = "PaytDate";
			this.PaytDate.ReadOnly = true;
			this.PaytDate.Width = 80;
			// 
			// Remarks
			// 
			this.Remarks.DataPropertyName = "Remarks";
			this.Remarks.HeaderText = "Remarks";
			this.Remarks.Name = "Remarks";
			this.Remarks.ReadOnly = true;
			this.Remarks.Width = 150;
			// 
			// EditParent
			// 
			this.EditParent.HeaderText = "Edit";
			this.EditParent.Name = "EditParent";
			this.EditParent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.EditParent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.EditParent.Text = "Edit";
			this.EditParent.ToolTipText = "Edit";
			this.EditParent.UseColumnTextForButtonValue = true;
			this.EditParent.Width = 60;
			// 
			// DeleteParent
			// 
			this.DeleteParent.HeaderText = "Delete";
			this.DeleteParent.Name = "DeleteParent";
			this.DeleteParent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DeleteParent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.DeleteParent.Text = "Delete";
			this.DeleteParent.ToolTipText = "Delete";
			this.DeleteParent.UseColumnTextForButtonValue = true;
			this.DeleteParent.Width = 70;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbWithoutGST);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.txtGSTIN);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.chkSameAddress);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtInvoiceNo);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtShippingAddress);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtBillingAddress);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmbPaymentMode);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dtInvoiceDate);
			this.groupBox1.Controls.Add(this.cmbIsOnCredit);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbIsPaid);
			this.groupBox1.Controls.Add(this.txtContactNumber);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.dtPaymentExDate);
			this.groupBox1.Controls.Add(this.txtRemark);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.TxtWebSite);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(26, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1088, 155);
			this.groupBox1.TabIndex = 126;
			this.groupBox1.TabStop = false;
			// 
			// rbWithoutGST
			// 
			this.rbWithoutGST.AutoSize = true;
			this.rbWithoutGST.Location = new System.Drawing.Point(703, 115);
			this.rbWithoutGST.Name = "rbWithoutGST";
			this.rbWithoutGST.Size = new System.Drawing.Size(96, 17);
			this.rbWithoutGST.TabIndex = 145;
			this.rbWithoutGST.Text = "Print W/0 GST";
			this.rbWithoutGST.UseVisualStyleBackColor = true;
			this.rbWithoutGST.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdBusiness);
			this.groupBox2.Controls.Add(this.rdIndividual);
			this.groupBox2.Location = new System.Drawing.Point(373, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(150, 33);
			this.groupBox2.TabIndex = 144;
			this.groupBox2.TabStop = false;
			// 
			// rdBusiness
			// 
			this.rdBusiness.AutoSize = true;
			this.rdBusiness.Location = new System.Drawing.Point(6, 11);
			this.rdBusiness.Name = "rdBusiness";
			this.rdBusiness.Size = new System.Drawing.Size(67, 17);
			this.rdBusiness.TabIndex = 139;
			this.rdBusiness.TabStop = true;
			this.rdBusiness.Text = "Business";
			this.rdBusiness.UseVisualStyleBackColor = true;
			this.rdBusiness.CheckedChanged += new System.EventHandler(this.rdBusiness_CheckedChanged);
			// 
			// rdIndividual
			// 
			this.rdIndividual.AutoSize = true;
			this.rdIndividual.Location = new System.Drawing.Point(79, 11);
			this.rdIndividual.Name = "rdIndividual";
			this.rdIndividual.Size = new System.Drawing.Size(70, 17);
			this.rdIndividual.TabIndex = 140;
			this.rdIndividual.TabStop = true;
			this.rdIndividual.Text = "Individual";
			this.rdIndividual.UseVisualStyleBackColor = true;
			this.rdIndividual.CheckedChanged += new System.EventHandler(this.rdIndividual_CheckedChanged);
			// 
			// txtGSTIN
			// 
			this.txtGSTIN.Location = new System.Drawing.Point(647, 29);
			this.txtGSTIN.Name = "txtGSTIN";
			this.txtGSTIN.Size = new System.Drawing.Size(118, 20);
			this.txtGSTIN.TabIndex = 143;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(542, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 13);
			this.label8.TabIndex = 142;
			this.label8.Text = "GSTIN                   :";
			// 
			// chkSameAddress
			// 
			this.chkSameAddress.AutoSize = true;
			this.chkSameAddress.Location = new System.Drawing.Point(545, 116);
			this.chkSameAddress.Name = "chkSameAddress";
			this.chkSameAddress.Size = new System.Drawing.Size(152, 17);
			this.chkSameAddress.TabIndex = 141;
			this.chkSameAddress.Text = "Shipping as Billing Address";
			this.chkSameAddress.UseVisualStyleBackColor = true;
			this.chkSameAddress.CheckedChanged += new System.EventHandler(this.chkSameAddress_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(268, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 13);
			this.label7.TabIndex = 138;
			this.label7.Text = "Invoice Type         :";
			// 
			// txtInvoiceNo
			// 
			this.txtInvoiceNo.Location = new System.Drawing.Point(131, 26);
			this.txtInvoiceNo.Name = "txtInvoiceNo";
			this.txtInvoiceNo.ReadOnly = true;
			this.txtInvoiceNo.Size = new System.Drawing.Size(131, 20);
			this.txtInvoiceNo.TabIndex = 137;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(23, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 13);
			this.label6.TabIndex = 136;
			this.label6.Text = "Invoice Number      :";
			// 
			// txtShippingAddress
			// 
			this.txtShippingAddress.Location = new System.Drawing.Point(373, 113);
			this.txtShippingAddress.Multiline = true;
			this.txtShippingAddress.Name = "txtShippingAddress";
			this.txtShippingAddress.Size = new System.Drawing.Size(149, 35);
			this.txtShippingAddress.TabIndex = 135;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(268, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 13);
			this.label5.TabIndex = 134;
			this.label5.Text = "Shipping  Address :";
			// 
			// txtBillingAddress
			// 
			this.txtBillingAddress.Location = new System.Drawing.Point(131, 113);
			this.txtBillingAddress.Multiline = true;
			this.txtBillingAddress.Name = "txtBillingAddress";
			this.txtBillingAddress.Size = new System.Drawing.Size(133, 35);
			this.txtBillingAddress.TabIndex = 133;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 13);
			this.label2.TabIndex = 132;
			this.label2.Text = "Billing Address        :";
			// 
			// cmbPaymentMode
			// 
			this.cmbPaymentMode.DisplayMember = "Active";
			this.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPaymentMode.FormattingEnabled = true;
			this.cmbPaymentMode.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
			this.cmbPaymentMode.Location = new System.Drawing.Point(905, 58);
			this.cmbPaymentMode.Name = "cmbPaymentMode";
			this.cmbPaymentMode.Size = new System.Drawing.Size(146, 21);
			this.cmbPaymentMode.TabIndex = 131;
			this.cmbPaymentMode.ValueMember = "01";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(810, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 13);
			this.label3.TabIndex = 130;
			this.label3.Text = "Customer Name  :";
			// 
			// dtInvoiceDate
			// 
			this.dtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtInvoiceDate.Location = new System.Drawing.Point(374, 84);
			this.dtInvoiceDate.Name = "dtInvoiceDate";
			this.dtInvoiceDate.Size = new System.Drawing.Size(149, 20);
			this.dtInvoiceDate.TabIndex = 7;
			// 
			// cmbIsOnCredit
			// 
			this.cmbIsOnCredit.DisplayMember = "Active";
			this.cmbIsOnCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbIsOnCredit.FormattingEnabled = true;
			this.cmbIsOnCredit.Location = new System.Drawing.Point(131, 83);
			this.cmbIsOnCredit.Name = "cmbIsOnCredit";
			this.cmbIsOnCredit.Size = new System.Drawing.Size(131, 21);
			this.cmbIsOnCredit.TabIndex = 6;
			this.cmbIsOnCredit.ValueMember = "01";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 124;
			this.label1.Text = "Is On Credit            :";
			// 
			// cmbIsPaid
			// 
			this.cmbIsPaid.DisplayMember = "Active";
			this.cmbIsPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbIsPaid.FormattingEnabled = true;
			this.cmbIsPaid.Location = new System.Drawing.Point(905, 86);
			this.cmbIsPaid.Name = "cmbIsPaid";
			this.cmbIsPaid.Size = new System.Drawing.Size(146, 21);
			this.cmbIsPaid.TabIndex = 5;
			this.cmbIsPaid.ValueMember = "01";
			// 
			// txtContactNumber
			// 
			this.txtContactNumber.Location = new System.Drawing.Point(131, 54);
			this.txtContactNumber.Name = "txtContactNumber";
			this.txtContactNumber.Size = new System.Drawing.Size(131, 20);
			this.txtContactNumber.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(905, 30);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(146, 20);
			this.txtName.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 13);
			this.label4.TabIndex = 119;
			this.label4.Text = "Mobile Number       :";
			// 
			// dtPaymentExDate
			// 
			this.dtPaymentExDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtPaymentExDate.Location = new System.Drawing.Point(647, 84);
			this.dtPaymentExDate.Name = "dtPaymentExDate";
			this.dtPaymentExDate.Size = new System.Drawing.Size(118, 20);
			this.dtPaymentExDate.TabIndex = 8;
			// 
			// txtRemark
			// 
			this.txtRemark.Location = new System.Drawing.Point(905, 114);
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(146, 20);
			this.txtRemark.TabIndex = 9;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(810, 115);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(91, 13);
			this.label14.TabIndex = 63;
			this.label14.Text = "Remarks             :";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(542, 89);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(101, 13);
			this.label15.TabIndex = 61;
			this.label15.Text = "Payment Exp. Dt.   :";
			// 
			// TxtWebSite
			// 
			this.TxtWebSite.Location = new System.Drawing.Point(647, 56);
			this.TxtWebSite.Name = "TxtWebSite";
			this.TxtWebSite.Size = new System.Drawing.Size(118, 20);
			this.TxtWebSite.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(373, 56);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(149, 20);
			this.txtEmail.TabIndex = 2;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(269, 88);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(98, 13);
			this.label16.TabIndex = 49;
			this.label16.Text = "Invoive Date         :";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(810, 88);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(90, 13);
			this.label18.TabIndex = 46;
			this.label18.Text = "Is Paid                :";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(542, 59);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 13);
			this.label19.TabIndex = 45;
			this.label19.Text = "Website                 :";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(268, 61);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(98, 13);
			this.label23.TabIndex = 41;
			this.label23.Text = "Email                     :";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(810, 59);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(90, 13);
			this.label24.TabIndex = 40;
			this.label24.Text = "Payment Mode   :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(26, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 53);
			this.pictureBox1.TabIndex = 131;
			this.pictureBox1.TabStop = false;
			// 
			// IsDelete
			// 
			this.IsDelete.HeaderText = "Select";
			this.IsDelete.Name = "IsDelete";
			this.IsDelete.Width = 60;
			// 
			// InvoiceItemID
			// 
			this.InvoiceItemID.DataPropertyName = "InvoiceItemID";
			this.InvoiceItemID.HeaderText = "InvoiceItemID";
			this.InvoiceItemID.Name = "InvoiceItemID";
			this.InvoiceItemID.ToolTipText = "InvoiceItemID";
			this.InvoiceItemID.Visible = false;
			this.InvoiceItemID.Width = 5;
			// 
			// InvoiceId1
			// 
			this.InvoiceId1.DataPropertyName = "InvoiceID";
			this.InvoiceId1.HeaderText = "InvoiceID";
			this.InvoiceId1.Name = "InvoiceId1";
			this.InvoiceId1.Visible = false;
			this.InvoiceId1.Width = 5;
			// 
			// ProductID
			// 
			this.ProductID.DataPropertyName = "ProductID";
			this.ProductID.HeaderText = "ProductID";
			this.ProductID.Name = "ProductID";
			this.ProductID.Visible = false;
			this.ProductID.Width = 5;
			// 
			// TaxID
			// 
			this.TaxID.DataPropertyName = "TaxID";
			this.TaxID.HeaderText = "TaxID";
			this.TaxID.Name = "TaxID";
			this.TaxID.Visible = false;
			this.TaxID.Width = 5;
			// 
			// SizeID
			// 
			this.SizeID.DataPropertyName = "SizeID";
			this.SizeID.HeaderText = "SizeID";
			this.SizeID.Name = "SizeID";
			this.SizeID.Visible = false;
			this.SizeID.Width = 5;
			// 
			// Product
			// 
			this.Product.DataPropertyName = "ProductName";
			this.Product.HeaderText = "Product Name";
			this.Product.Name = "Product";
			this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Product.Width = 175;
			// 
			// HSN_SAC
			// 
			this.HSN_SAC.DataPropertyName = "HSN_SAC";
			this.HSN_SAC.HeaderText = "HSN/SAC";
			this.HSN_SAC.Name = "HSN_SAC";
			this.HSN_SAC.ReadOnly = true;
			this.HSN_SAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Make
			// 
			this.Make.DataPropertyName = "Make";
			this.Make.HeaderText = "Make";
			this.Make.Name = "Make";
			this.Make.ReadOnly = true;
			this.Make.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Quantity
			// 
			this.Quantity.DataPropertyName = "Quantity";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = "0";
			this.Quantity.DefaultCellStyle = dataGridViewCellStyle1;
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Quantity.Width = 50;
			// 
			// Unit
			// 
			this.Unit.DataPropertyName = "Unit";
			this.Unit.HeaderText = "Unit";
			this.Unit.Name = "Unit";
			this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Unit.Width = 50;
			// 
			// Size
			// 
			this.Size.DataPropertyName = "SizeType";
			this.Size.HeaderText = "Size";
			this.Size.Name = "Size";
			this.Size.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Size.Width = 70;
			// 
			// RateperUnit
			// 
			this.RateperUnit.DataPropertyName = "RatePerUnit";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			this.RateperUnit.DefaultCellStyle = dataGridViewCellStyle2;
			this.RateperUnit.HeaderText = "Rate/Unit";
			this.RateperUnit.Name = "RateperUnit";
			this.RateperUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.RateperUnit.Width = 75;
			// 
			// Tax
			// 
			this.Tax.DataPropertyName = "TaxPercentage";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			this.Tax.DefaultCellStyle = dataGridViewCellStyle3;
			this.Tax.HeaderText = "Tax %";
			this.Tax.Name = "Tax";
			this.Tax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Tax.Width = 50;
			// 
			// TaxAmt
			// 
			this.TaxAmt.DataPropertyName = "TaxAmount";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.NullValue = "0";
			this.TaxAmt.DefaultCellStyle = dataGridViewCellStyle4;
			this.TaxAmt.HeaderText = "Tax Amt";
			this.TaxAmt.Name = "TaxAmt";
			this.TaxAmt.ReadOnly = true;
			this.TaxAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TaxAmt.Width = 60;
			// 
			// Discount
			// 
			this.Discount.DataPropertyName = "Discount";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			this.Discount.DefaultCellStyle = dataGridViewCellStyle5;
			this.Discount.HeaderText = "Discount";
			this.Discount.Name = "Discount";
			this.Discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Discount.Width = 60;
			// 
			// DiscountAmt
			// 
			this.DiscountAmt.DataPropertyName = "DiscountAmount";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			dataGridViewCellStyle6.Format = "N2";
			dataGridViewCellStyle6.NullValue = "0";
			this.DiscountAmt.DefaultCellStyle = dataGridViewCellStyle6;
			this.DiscountAmt.HeaderText = "Disc. Amt";
			this.DiscountAmt.Name = "DiscountAmt";
			this.DiscountAmt.ReadOnly = true;
			this.DiscountAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DiscountAmt.Width = 80;
			// 
			// TotalAmt
			// 
			this.TotalAmt.DataPropertyName = "TotalAmount";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			dataGridViewCellStyle7.Format = "N2";
			dataGridViewCellStyle7.NullValue = "0";
			this.TotalAmt.DefaultCellStyle = dataGridViewCellStyle7;
			this.TotalAmt.HeaderText = "Total Amt";
			this.TotalAmt.Name = "TotalAmt";
			this.TotalAmt.ReadOnly = true;
			this.TotalAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Remark
			// 
			this.Remark.DataPropertyName = "Remark";
			dataGridViewCellStyle8.Format = "C2";
			dataGridViewCellStyle8.NullValue = null;
			this.Remark.DefaultCellStyle = dataGridViewCellStyle8;
			this.Remark.HeaderText = "Remark";
			this.Remark.Name = "Remark";
			this.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Remark.Visible = false;
			this.Remark.Width = 60;
			// 
			// UnitID
			// 
			this.UnitID.DataPropertyName = "UnitID";
			this.UnitID.HeaderText = "UnitID";
			this.UnitID.Name = "UnitID";
			this.UnitID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.UnitID.Visible = false;
			this.UnitID.Width = 5;
			// 
			// frmInvoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
			this.ClientSize = new System.Drawing.Size(1144, 633);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmInvoice";
			this.Text = "Invoice";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmInvoice_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PrintGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPaymentExDate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtWebSite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.DateTimePicker dtInvoiceDate;
        private System.Windows.Forms.ComboBox cmbIsOnCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIsPaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.TextBox txtShippingAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillingAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdIndividual;
        private System.Windows.Forms.RadioButton rdBusiness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkSameAddress;
        private System.Windows.Forms.TextBox txtGSTIN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView PrintGrid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbWithoutGST;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
		private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn Website;
		private System.Windows.Forms.DataGridViewTextBoxColumn IsPaid;
		private System.Windows.Forms.DataGridViewTextBoxColumn IsOnCredit;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn PaytDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
		private System.Windows.Forms.DataGridViewButtonColumn EditParent;
		private System.Windows.Forms.DataGridViewButtonColumn DeleteParent;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceItemID;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaxID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeID;
		private System.Windows.Forms.DataGridViewComboBoxColumn Product;
		private System.Windows.Forms.DataGridViewTextBoxColumn HSN_SAC;
		private System.Windows.Forms.DataGridViewTextBoxColumn Make;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewComboBoxColumn Unit;
		private System.Windows.Forms.DataGridViewComboBoxColumn Size;
		private System.Windows.Forms.DataGridViewTextBoxColumn RateperUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmt;
		private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmt;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmt;
		private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
	}
}