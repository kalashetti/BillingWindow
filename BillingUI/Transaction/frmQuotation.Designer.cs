namespace AC.Billing.UI.Transaction
{
    partial class frmQuotation
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IsDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuotationItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvQuotation = new System.Windows.Forms.DataGridView();
            this.QuotationID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseExpectedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentModeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editparent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteParent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dtQuotationDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrintGrid = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuotation)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(525, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 23);
            this.label12.TabIndex = 133;
            this.label12.Text = "Quotation";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PrintGrid);
            this.panel2.Controls.Add(this.btnPrintPreview);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnDeleteRow);
            this.panel2.Controls.Add(this.btnAddRow);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(27, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 41);
            this.panel2.TabIndex = 97;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnPrintPreview.FlatAppearance.BorderSize = 0;
            this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreview.Location = new System.Drawing.Point(624, 11);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(90, 23);
            this.btnPrintPreview.TabIndex = 20;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(720, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnDeleteRow.FlatAppearance.BorderSize = 0;
            this.btnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRow.Location = new System.Drawing.Point(543, 11);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRow.TabIndex = 18;
            this.btnDeleteRow.Text = "Delete Row";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnAddRow.FlatAppearance.BorderSize = 0;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Location = new System.Drawing.Point(461, 11);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 17;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = false;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(379, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(298, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(27, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 202);
            this.panel1.TabIndex = 98;
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
            this.QuotationItemID,
            this.QuotationID2,
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
            this.dataGridView2.Location = new System.Drawing.Point(3, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1078, 169);
            this.dataGridView2.TabIndex = 40;
            this.dataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            // 
            // IsDelete
            // 
            this.IsDelete.HeaderText = "Select";
            this.IsDelete.Name = "IsDelete";
            this.IsDelete.Width = 60;
            // 
            // QuotationItemID
            // 
            this.QuotationItemID.DataPropertyName = "QuotationItemID";
            this.QuotationItemID.HeaderText = "InvoiceItemID";
            this.QuotationItemID.Name = "QuotationItemID";
            this.QuotationItemID.ToolTipText = "InvoiceItemID";
            this.QuotationItemID.Visible = false;
            this.QuotationItemID.Width = 5;
            // 
            // QuotationID2
            // 
            this.QuotationID2.DataPropertyName = "QuotationID";
            this.QuotationID2.HeaderText = "InvoiceID";
            this.QuotationID2.Name = "QuotationID2";
            this.QuotationID2.Visible = false;
            this.QuotationID2.Width = 5;
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
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(937, 175);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(118, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(853, 178);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Grand Total    :";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.gvQuotation);
            this.panel3.Location = new System.Drawing.Point(27, 454);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1088, 170);
            this.panel3.TabIndex = 99;
            // 
            // gvQuotation
            // 
            this.gvQuotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQuotation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuotationID1,
            this.CustomerName,
            this.QuotationDate,
            this.PurchaseExpectedBy,
            this.PaymentMode,
            this.PaymentModeID,
            this.Remarks,
            this.Editparent,
            this.DeleteParent});
            this.gvQuotation.Location = new System.Drawing.Point(3, 3);
            this.gvQuotation.Name = "gvQuotation";
            this.gvQuotation.Size = new System.Drawing.Size(1078, 150);
            this.gvQuotation.TabIndex = 8;
            // 
            // QuotationID1
            // 
            this.QuotationID1.DataPropertyName = "QuotationID";
            this.QuotationID1.HeaderText = "QuotationID";
            this.QuotationID1.Name = "QuotationID1";
            this.QuotationID1.ToolTipText = "QuotationID";
            this.QuotationID1.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 250;
            // 
            // QuotationDate
            // 
            this.QuotationDate.DataPropertyName = "QuotationDate";
            this.QuotationDate.HeaderText = "QuotationDate";
            this.QuotationDate.Name = "QuotationDate";
            this.QuotationDate.ToolTipText = "Quotation Date";
            this.QuotationDate.Width = 120;
            // 
            // PurchaseExpectedBy
            // 
            this.PurchaseExpectedBy.DataPropertyName = "PurchaseExpectedBy";
            this.PurchaseExpectedBy.HeaderText = "Purchase Expected On";
            this.PurchaseExpectedBy.Name = "PurchaseExpectedBy";
            this.PurchaseExpectedBy.Width = 150;
            // 
            // PaymentMode
            // 
            this.PaymentMode.DataPropertyName = "PaymentMode";
            this.PaymentMode.HeaderText = "Payment Mode";
            this.PaymentMode.Name = "PaymentMode";
            this.PaymentMode.Width = 120;
            // 
            // PaymentModeID
            // 
            this.PaymentModeID.DataPropertyName = "PaymentModeID";
            this.PaymentModeID.HeaderText = "PaymentModeID";
            this.PaymentModeID.Name = "PaymentModeID";
            this.PaymentModeID.ToolTipText = "PaymentModeID";
            this.PaymentModeID.Visible = false;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remark";
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 200;
            // 
            // Editparent
            // 
            this.Editparent.HeaderText = "Edit";
            this.Editparent.Name = "Editparent";
            this.Editparent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editparent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editparent.Text = "Edit";
            this.Editparent.ToolTipText = "Edit";
            this.Editparent.UseColumnTextForButtonValue = true;
            this.Editparent.Width = 90;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPurchaseDate);
            this.groupBox1.Controls.Add(this.dtQuotationDate);
            this.groupBox1.Controls.Add(this.cmbPaymentMode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 98);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPurchaseDate.Location = new System.Drawing.Point(804, 58);
            this.dtPurchaseDate.Name = "dtPurchaseDate";
            this.dtPurchaseDate.Size = new System.Drawing.Size(139, 20);
            this.dtPurchaseDate.TabIndex = 3;
            // 
            // dtQuotationDate
            // 
            this.dtQuotationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtQuotationDate.Location = new System.Drawing.Point(804, 32);
            this.dtQuotationDate.Name = "dtQuotationDate";
            this.dtQuotationDate.Size = new System.Drawing.Size(139, 20);
            this.dtQuotationDate.TabIndex = 2;
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Location = new System.Drawing.Point(485, 31);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(100, 21);
            this.cmbPaymentMode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Payment Mode          :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(118, 58);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(467, 20);
            this.txtRemarks.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Remarks            :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Purchase Expected On            :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Quotation Date                         :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Customer Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 53);
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // PrintGrid
            // 
            this.PrintGrid.AllowUserToAddRows = false;
            this.PrintGrid.AllowUserToDeleteRows = false;
            this.PrintGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintGrid.Location = new System.Drawing.Point(-1, -22);
            this.PrintGrid.Name = "PrintGrid";
            this.PrintGrid.Size = new System.Drawing.Size(240, 150);
            this.PrintGrid.TabIndex = 41;
            this.PrintGrid.Visible = false;
            // 
            // frmQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1144, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuotation";
            this.Text = "Quotation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuotation_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvQuotation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtPurchaseDate;
        private System.Windows.Forms.DateTimePicker dtQuotationDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvQuotation;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuotationID1;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuotationDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseExpectedBy;
		private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMode;
		private System.Windows.Forms.DataGridViewTextBoxColumn PaymentModeID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
		private System.Windows.Forms.DataGridViewButtonColumn Editparent;
		private System.Windows.Forms.DataGridViewButtonColumn DeleteParent;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationID2;
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
        private System.Windows.Forms.DataGridView PrintGrid;
	}
}