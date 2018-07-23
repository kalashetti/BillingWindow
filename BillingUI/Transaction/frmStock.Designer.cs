namespace AC.Billing.UI.Transaction
{
    partial class frmStock
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
			this.label14 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dvStock = new System.Windows.Forms.DataGridView();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TaxID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RateperUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TaxAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiscountAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtTotalAmount = new System.Windows.Forms.TextBox();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtTaxAmount = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTaxPer = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbProduct = new System.Windows.Forms.ComboBox();
			this.cbUnit = new System.Windows.Forms.ComboBox();
			this.cmbTax = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbSize = new System.Windows.Forms.ComboBox();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.txtDiscountAmount = new System.Windows.Forms.TextBox();
			this.txtMake = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvStock)).BeginInit();
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
			this.label14.Location = new System.Drawing.Point(529, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(109, 23);
			this.label14.TabIndex = 134;
			this.label14.Text = "Stock Entry";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.dvStock);
			this.panel3.Location = new System.Drawing.Point(25, 351);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1091, 269);
			this.panel3.TabIndex = 86;
			// 
			// dvStock
			// 
			this.dvStock.AllowUserToAddRows = false;
			this.dvStock.AllowUserToDeleteRows = false;
			this.dvStock.AllowUserToResizeColumns = false;
			this.dvStock.AllowUserToResizeRows = false;
			this.dvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.TaxID,
            this.SizeID,
            this.Product,
            this.Make,
            this.Quantity,
            this.Unit,
            this.SizeType,
            this.RateperUnit,
            this.Tax,
            this.TaxAmt,
            this.Discount,
            this.DiscountAmt,
            this.TotalAmt,
            this.Remark,
            this.UnitID,
            this.Edit,
            this.Delete,
            this.Stock});
			this.dvStock.Location = new System.Drawing.Point(3, 3);
			this.dvStock.Name = "dvStock";
			this.dvStock.Size = new System.Drawing.Size(1081, 243);
			this.dvStock.TabIndex = 11;
			this.dvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvStock_CellContentClick);
			// 
			// ProductID
			// 
			this.ProductID.DataPropertyName = "ProductID";
			this.ProductID.HeaderText = "ProductID";
			this.ProductID.Name = "ProductID";
			this.ProductID.Visible = false;
			// 
			// TaxID
			// 
			this.TaxID.DataPropertyName = "TaxID";
			this.TaxID.HeaderText = "TaxID";
			this.TaxID.Name = "TaxID";
			this.TaxID.Visible = false;
			// 
			// SizeID
			// 
			this.SizeID.DataPropertyName = "SizeID";
			this.SizeID.HeaderText = "SizeID";
			this.SizeID.Name = "SizeID";
			this.SizeID.Visible = false;
			// 
			// Product
			// 
			this.Product.DataPropertyName = "ProductName";
			this.Product.HeaderText = "Product Name";
			this.Product.Name = "Product";
			this.Product.ReadOnly = true;
			this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Product.Width = 180;
			// 
			// Make
			// 
			this.Make.DataPropertyName = "Make";
			this.Make.HeaderText = "Make";
			this.Make.Name = "Make";
			this.Make.ReadOnly = true;
			// 
			// Quantity
			// 
			this.Quantity.DataPropertyName = "Quantity";
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = "0";
			this.Quantity.DefaultCellStyle = dataGridViewCellStyle1;
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			this.Quantity.Width = 60;
			// 
			// Unit
			// 
			this.Unit.DataPropertyName = "Unit";
			this.Unit.HeaderText = "Unit";
			this.Unit.Name = "Unit";
			this.Unit.ReadOnly = true;
			this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Unit.Width = 50;
			// 
			// SizeType
			// 
			this.SizeType.DataPropertyName = "Size";
			this.SizeType.HeaderText = "Size";
			this.SizeType.Name = "SizeType";
			this.SizeType.ReadOnly = true;
			this.SizeType.Width = 80;
			// 
			// RateperUnit
			// 
			this.RateperUnit.DataPropertyName = "RatePerUnit";
			this.RateperUnit.HeaderText = "Rate/Unit";
			this.RateperUnit.Name = "RateperUnit";
			this.RateperUnit.ReadOnly = true;
			this.RateperUnit.Width = 75;
			// 
			// Tax
			// 
			this.Tax.DataPropertyName = "TaxPercentage";
			this.Tax.HeaderText = "Tax %";
			this.Tax.Name = "Tax";
			this.Tax.ReadOnly = true;
			this.Tax.Width = 60;
			// 
			// TaxAmt
			// 
			this.TaxAmt.DataPropertyName = "TaxAmount";
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = "0";
			this.TaxAmt.DefaultCellStyle = dataGridViewCellStyle2;
			this.TaxAmt.HeaderText = "Tax Amt";
			this.TaxAmt.Name = "TaxAmt";
			this.TaxAmt.ReadOnly = true;
			this.TaxAmt.Width = 80;
			// 
			// Discount
			// 
			this.Discount.DataPropertyName = "Discount";
			this.Discount.HeaderText = "Discount";
			this.Discount.Name = "Discount";
			this.Discount.ReadOnly = true;
			this.Discount.Width = 70;
			// 
			// DiscountAmt
			// 
			this.DiscountAmt.DataPropertyName = "DiscountAmount";
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = "0";
			this.DiscountAmt.DefaultCellStyle = dataGridViewCellStyle3;
			this.DiscountAmt.HeaderText = "Disc. Amt";
			this.DiscountAmt.Name = "DiscountAmt";
			this.DiscountAmt.ReadOnly = true;
			this.DiscountAmt.Width = 80;
			// 
			// TotalAmt
			// 
			this.TotalAmt.DataPropertyName = "TotalAmount";
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.NullValue = "0";
			this.TotalAmt.DefaultCellStyle = dataGridViewCellStyle4;
			this.TotalAmt.HeaderText = "Total Amt";
			this.TotalAmt.Name = "TotalAmt";
			this.TotalAmt.ReadOnly = true;
			this.TotalAmt.Width = 90;
			// 
			// Remark
			// 
			this.Remark.DataPropertyName = "Remark";
			dataGridViewCellStyle5.Format = "C2";
			dataGridViewCellStyle5.NullValue = null;
			this.Remark.DefaultCellStyle = dataGridViewCellStyle5;
			this.Remark.HeaderText = "Remark";
			this.Remark.Name = "Remark";
			this.Remark.ReadOnly = true;
			this.Remark.Visible = false;
			// 
			// UnitID
			// 
			this.UnitID.DataPropertyName = "UnitID";
			this.UnitID.HeaderText = "UnitID";
			this.UnitID.Name = "UnitID";
			this.UnitID.Visible = false;
			// 
			// Edit
			// 
			this.Edit.HeaderText = "Edit";
			this.Edit.Name = "Edit";
			this.Edit.Text = "Edit";
			this.Edit.UseColumnTextForButtonValue = true;
			this.Edit.Width = 50;
			// 
			// Delete
			// 
			this.Delete.HeaderText = "Delete";
			this.Delete.Name = "Delete";
			this.Delete.Text = "Delete";
			this.Delete.UseColumnTextForButtonValue = true;
			this.Delete.Width = 55;
			// 
			// Stock
			// 
			this.Stock.DataPropertyName = "StockID";
			this.Stock.HeaderText = "StockID";
			this.Stock.Name = "Stock";
			this.Stock.Visible = false;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnRefresh);
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Location = new System.Drawing.Point(25, 294);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1091, 51);
			this.panel2.TabIndex = 85;
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Location = new System.Drawing.Point(604, 13);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 67;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(507, 13);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 66;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(411, 13);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 48;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtTotalAmount);
			this.groupBox1.Controls.Add(this.txtDiscount);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtTaxAmount);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtTaxPer);
			this.groupBox1.Controls.Add(this.txtQuantity);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbProduct);
			this.groupBox1.Controls.Add(this.cbUnit);
			this.groupBox1.Controls.Add(this.cmbTax);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.cmbSize);
			this.groupBox1.Controls.Add(this.txtRemark);
			this.groupBox1.Controls.Add(this.txtRate);
			this.groupBox1.Controls.Add(this.txtDiscountAmount);
			this.groupBox1.Controls.Add(this.txtMake);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(25, 106);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1091, 182);
			this.groupBox1.TabIndex = 84;
			this.groupBox1.TabStop = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(812, 156);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 13);
			this.label13.TabIndex = 63;
			this.label13.Text = "Total Amount       :";
			// 
			// txtTotalAmount
			// 
			this.txtTotalAmount.Location = new System.Drawing.Point(912, 153);
			this.txtTotalAmount.MaxLength = 10;
			this.txtTotalAmount.Name = "txtTotalAmount";
			this.txtTotalAmount.ReadOnly = true;
			this.txtTotalAmount.Size = new System.Drawing.Size(105, 20);
			this.txtTotalAmount.TabIndex = 62;
			// 
			// txtDiscount
			// 
			this.txtDiscount.Location = new System.Drawing.Point(679, 117);
			this.txtDiscount.MaxLength = 10;
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(100, 20);
			this.txtDiscount.TabIndex = 61;
			this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
			this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(812, 120);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(94, 13);
			this.label12.TabIndex = 60;
			this.label12.Text = "Discount Amount :";
			// 
			// txtTaxAmount
			// 
			this.txtTaxAmount.Location = new System.Drawing.Point(912, 76);
			this.txtTaxAmount.MaxLength = 10;
			this.txtTaxAmount.Name = "txtTaxAmount";
			this.txtTaxAmount.ReadOnly = true;
			this.txtTaxAmount.Size = new System.Drawing.Size(107, 20);
			this.txtTaxAmount.TabIndex = 59;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(812, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 58;
			this.label4.Text = "Tax Amount         :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(620, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 57;
			this.label2.Text = "Tax %      :";
			// 
			// txtTaxPer
			// 
			this.txtTaxPer.Location = new System.Drawing.Point(679, 76);
			this.txtTaxPer.MaxLength = 10;
			this.txtTaxPer.Name = "txtTaxPer";
			this.txtTaxPer.Size = new System.Drawing.Size(100, 20);
			this.txtTaxPer.TabIndex = 56;
			this.txtTaxPer.TextChanged += new System.EventHandler(this.txtTaxPer_TextChanged);
			this.txtTaxPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxPer_KeyPress);
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(64, 80);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(170, 20);
			this.txtQuantity.TabIndex = 55;
			this.txtQuantity.Text = "0";
			this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
			this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 54;
			this.label1.Text = "Quantity :";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// cmbProduct
			// 
			this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProduct.FormattingEnabled = true;
			this.cmbProduct.Location = new System.Drawing.Point(62, 33);
			this.cmbProduct.Name = "cmbProduct";
			this.cmbProduct.Size = new System.Drawing.Size(172, 21);
			this.cmbProduct.TabIndex = 53;
			this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
			// 
			// cbUnit
			// 
			this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUnit.FormattingEnabled = true;
			this.cbUnit.Location = new System.Drawing.Point(483, 33);
			this.cbUnit.Name = "cbUnit";
			this.cbUnit.Size = new System.Drawing.Size(100, 21);
			this.cbUnit.TabIndex = 52;
			this.cbUnit.SelectedIndexChanged += new System.EventHandler(this.cbUnit_SelectedIndexChanged);
			this.cbUnit.SelectionChangeCommitted += new System.EventHandler(this.cbUnit_SelectionChangeCommitted);
			// 
			// cmbTax
			// 
			this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTax.FormattingEnabled = true;
			this.cmbTax.Location = new System.Drawing.Point(483, 79);
			this.cmbTax.Name = "cmbTax";
			this.cmbTax.Size = new System.Drawing.Size(100, 21);
			this.cmbTax.TabIndex = 8;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(452, 83);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(31, 13);
			this.label11.TabIndex = 51;
			this.label11.Text = "Tax :";
			// 
			// cmbSize
			// 
			this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSize.FormattingEnabled = true;
			this.cmbSize.Location = new System.Drawing.Point(679, 33);
			this.cmbSize.Name = "cmbSize";
			this.cmbSize.Size = new System.Drawing.Size(100, 21);
			this.cmbSize.TabIndex = 6;
			// 
			// txtRemark
			// 
			this.txtRemark.Location = new System.Drawing.Point(912, 34);
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(174, 20);
			this.txtRemark.TabIndex = 10;
			// 
			// txtRate
			// 
			this.txtRate.Location = new System.Drawing.Point(314, 80);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(121, 20);
			this.txtRate.TabIndex = 9;
			this.txtRate.Text = "0";
			this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
			this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
			// 
			// txtDiscountAmount
			// 
			this.txtDiscountAmount.Location = new System.Drawing.Point(912, 117);
			this.txtDiscountAmount.MaxLength = 10;
			this.txtDiscountAmount.Name = "txtDiscountAmount";
			this.txtDiscountAmount.ReadOnly = true;
			this.txtDiscountAmount.Size = new System.Drawing.Size(105, 20);
			this.txtDiscountAmount.TabIndex = 7;
			// 
			// txtMake
			// 
			this.txtMake.Location = new System.Drawing.Point(314, 33);
			this.txtMake.Name = "txtMake";
			this.txtMake.Size = new System.Drawing.Size(121, 20);
			this.txtMake.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(812, 36);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 13);
			this.label10.TabIndex = 49;
			this.label10.Text = "Remarks              :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(620, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 13);
			this.label9.TabIndex = 48;
			this.label9.Text = "Discount  :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(251, 85);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 13);
			this.label8.TabIndex = 47;
			this.label8.Text = "Rate/Unit :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(620, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 46;
			this.label7.Text = "Size         :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(451, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 45;
			this.label6.Text = "Unit :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(251, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 44;
			this.label5.Text = "Make        :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 42;
			this.label3.Text = "Product :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(25, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 53);
			this.pictureBox1.TabIndex = 136;
			this.pictureBox1.TabStop = false;
			// 
			// frmStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
			this.ClientSize = new System.Drawing.Size(1144, 632);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmStock";
			this.Text = "Stock Entry";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStock_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dvStock)).EndInit();
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaxPer;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.DataGridView dvStock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaxID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product;
		private System.Windows.Forms.DataGridViewTextBoxColumn Make;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeType;
		private System.Windows.Forms.DataGridViewTextBoxColumn RateperUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmt;
		private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmt;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmt;
		private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
		private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
	}
}