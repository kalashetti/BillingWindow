namespace AC.Billing.UI.Master
{
    partial class frmProduct
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
			this.label12 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductCateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductSubCateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TaxID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RatePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbUnit = new System.Windows.Forms.ComboBox();
			this.cmbTax = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbSize = new System.Windows.Forms.ComboBox();
			this.cmbSubCategory = new System.Windows.Forms.ComboBox();
			this.cmbProductCategory = new System.Windows.Forms.ComboBox();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.txtMake = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtProduct = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(503, 34);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(141, 23);
			this.label12.TabIndex = 84;
			this.label12.Text = "Product Master";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Location = new System.Drawing.Point(50, 212);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1038, 51);
			this.panel2.TabIndex = 82;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(528, 13);
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
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(427, 13);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 48;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Location = new System.Drawing.Point(50, 269);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1038, 336);
			this.panel3.TabIndex = 83;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.ProductCateId,
            this.ProductSubCateID,
            this.TaxID,
            this.SizeID,
            this.CategoryName,
            this.SubCategory,
            this.ProductName,
            this.Make,
            this.Description,
            this.Tax,
            this.Unit,
            this.SizeName,
            this.RatePerUnit,
            this.Discount,
            this.Remark,
            this.UnitID,
            this.Edit,
            this.Delete});
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1028, 315);
			this.dataGridView1.TabIndex = 23;
			// 
			// Product
			// 
			this.Product.DataPropertyName = "ProductID";
			this.Product.HeaderText = "ProductID";
			this.Product.Name = "Product";
			this.Product.Visible = false;
			this.Product.Width = 50;
			// 
			// ProductCateId
			// 
			this.ProductCateId.DataPropertyName = "ProductCategoryID";
			this.ProductCateId.HeaderText = "ProductCateId";
			this.ProductCateId.Name = "ProductCateId";
			this.ProductCateId.Visible = false;
			this.ProductCateId.Width = 50;
			// 
			// ProductSubCateID
			// 
			this.ProductSubCateID.DataPropertyName = "ProductSubCategoryID";
			this.ProductSubCateID.HeaderText = "ProductSubCategoryID";
			this.ProductSubCateID.Name = "ProductSubCateID";
			this.ProductSubCateID.Visible = false;
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
			// CategoryName
			// 
			this.CategoryName.DataPropertyName = "CategoryName";
			this.CategoryName.HeaderText = "Category";
			this.CategoryName.Name = "CategoryName";
			this.CategoryName.Width = 110;
			// 
			// SubCategory
			// 
			this.SubCategory.DataPropertyName = "SubCategoryName";
			this.SubCategory.HeaderText = "Sub Category";
			this.SubCategory.Name = "SubCategory";
			this.SubCategory.Width = 110;
			// 
			// ProductName
			// 
			this.ProductName.DataPropertyName = "ProductName";
			this.ProductName.HeaderText = "Product Name";
			this.ProductName.Name = "ProductName";
			this.ProductName.Width = 180;
			// 
			// Make
			// 
			this.Make.DataPropertyName = "Make";
			this.Make.HeaderText = "Make";
			this.Make.Name = "Make";
			// 
			// Description
			// 
			this.Description.DataPropertyName = "ProductDescription";
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.Width = 115;
			// 
			// Tax
			// 
			this.Tax.DataPropertyName = "TaxPercentage";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			this.Tax.DefaultCellStyle = dataGridViewCellStyle1;
			this.Tax.HeaderText = "Tax %";
			this.Tax.Name = "Tax";
			this.Tax.Width = 60;
			// 
			// Unit
			// 
			this.Unit.DataPropertyName = "Unit";
			this.Unit.HeaderText = "Unit";
			this.Unit.Name = "Unit";
			this.Unit.Width = 50;
			// 
			// SizeName
			// 
			this.SizeName.DataPropertyName = "SizeName";
			this.SizeName.HeaderText = "Size";
			this.SizeName.Name = "SizeName";
			this.SizeName.Width = 50;
			// 
			// RatePerUnit
			// 
			this.RatePerUnit.DataPropertyName = "RatePerUnit";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			this.RatePerUnit.DefaultCellStyle = dataGridViewCellStyle2;
			this.RatePerUnit.HeaderText = "Rate";
			this.RatePerUnit.Name = "RatePerUnit";
			this.RatePerUnit.Width = 50;
			// 
			// Discount
			// 
			this.Discount.DataPropertyName = "Discount";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			this.Discount.DefaultCellStyle = dataGridViewCellStyle3;
			this.Discount.HeaderText = "Discount";
			this.Discount.Name = "Discount";
			this.Discount.Width = 55;
			// 
			// Remark
			// 
			this.Remark.DataPropertyName = "Remark";
			this.Remark.HeaderText = "Remark";
			this.Remark.Name = "Remark";
			this.Remark.Visible = false;
			this.Remark.Width = 60;
			// 
			// UnitID
			// 
			this.UnitID.DataPropertyName = "UnitID";
			this.UnitID.HeaderText = "UnitID";
			this.UnitID.Name = "UnitID";
			this.UnitID.Visible = false;
			this.UnitID.Width = 10;
			// 
			// Edit
			// 
			this.Edit.HeaderText = "Edit";
			this.Edit.Name = "Edit";
			this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Edit.Text = "Edit";
			this.Edit.ToolTipText = "Edit";
			this.Edit.UseColumnTextForButtonValue = true;
			this.Edit.Width = 50;
			// 
			// Delete
			// 
			this.Delete.HeaderText = "Delete";
			this.Delete.Name = "Delete";
			this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Delete.Text = "Delete";
			this.Delete.ToolTipText = "Delete";
			this.Delete.UseColumnTextForButtonValue = true;
			this.Delete.Width = 50;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbUnit);
			this.groupBox1.Controls.Add(this.cmbTax);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.cmbSize);
			this.groupBox1.Controls.Add(this.cmbSubCategory);
			this.groupBox1.Controls.Add(this.cmbProductCategory);
			this.groupBox1.Controls.Add(this.txtRemark);
			this.groupBox1.Controls.Add(this.txtRate);
			this.groupBox1.Controls.Add(this.txtDiscount);
			this.groupBox1.Controls.Add(this.txtMake);
			this.groupBox1.Controls.Add(this.txtDescription);
			this.groupBox1.Controls.Add(this.txtProduct);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(50, 99);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1038, 107);
			this.groupBox1.TabIndex = 70;
			this.groupBox1.TabStop = false;
			// 
			// cbUnit
			// 
			this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUnit.FormattingEnabled = true;
			this.cbUnit.Location = new System.Drawing.Point(329, 45);
			this.cbUnit.Name = "cbUnit";
			this.cbUnit.Size = new System.Drawing.Size(128, 21);
			this.cbUnit.TabIndex = 52;
			this.cbUnit.SelectedIndexChanged += new System.EventHandler(this.cbUnit_SelectedIndexChanged);
			// 
			// cmbTax
			// 
			this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTax.FormattingEnabled = true;
			this.cmbTax.Location = new System.Drawing.Point(101, 72);
			this.cmbTax.Name = "cmbTax";
			this.cmbTax.Size = new System.Drawing.Size(126, 21);
			this.cmbTax.TabIndex = 8;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(14, 77);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 13);
			this.label11.TabIndex = 51;
			this.label11.Text = "Tax                   :";
			// 
			// cmbSize
			// 
			this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSize.FormattingEnabled = true;
			this.cmbSize.Location = new System.Drawing.Point(591, 46);
			this.cmbSize.Name = "cmbSize";
			this.cmbSize.Size = new System.Drawing.Size(100, 21);
			this.cmbSize.TabIndex = 6;
			// 
			// cmbSubCategory
			// 
			this.cmbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSubCategory.FormattingEnabled = true;
			this.cmbSubCategory.Location = new System.Drawing.Point(866, 19);
			this.cmbSubCategory.Name = "cmbSubCategory";
			this.cmbSubCategory.Size = new System.Drawing.Size(155, 21);
			this.cmbSubCategory.TabIndex = 3;
			// 
			// cmbProductCategory
			// 
			this.cmbProductCategory.DisplayMember = "0";
			this.cmbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProductCategory.FormattingEnabled = true;
			this.cmbProductCategory.Location = new System.Drawing.Point(591, 18);
			this.cmbProductCategory.Name = "cmbProductCategory";
			this.cmbProductCategory.Size = new System.Drawing.Size(170, 21);
			this.cmbProductCategory.TabIndex = 2;
			this.cmbProductCategory.ValueMember = "0";
			this.cmbProductCategory.SelectedIndexChanged += new System.EventHandler(this.cmbProductCategory_SelectedIndexChanged);
			// 
			// txtRemark
			// 
			this.txtRemark.Location = new System.Drawing.Point(866, 73);
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(155, 20);
			this.txtRemark.TabIndex = 10;
			// 
			// txtRate
			// 
			this.txtRate.Location = new System.Drawing.Point(329, 72);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(128, 20);
			this.txtRate.TabIndex = 9;
			this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
			// 
			// txtDiscount
			// 
			this.txtDiscount.Location = new System.Drawing.Point(866, 46);
			this.txtDiscount.MaxLength = 10;
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(155, 20);
			this.txtDiscount.TabIndex = 7;
			this.txtDiscount.Text = "0";
			// 
			// txtMake
			// 
			this.txtMake.Location = new System.Drawing.Point(101, 45);
			this.txtMake.Name = "txtMake";
			this.txtMake.Size = new System.Drawing.Size(126, 20);
			this.txtMake.TabIndex = 4;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(591, 74);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(170, 20);
			this.txtDescription.TabIndex = 1;
			// 
			// txtProduct
			// 
			this.txtProduct.Location = new System.Drawing.Point(101, 19);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new System.Drawing.Size(356, 20);
			this.txtProduct.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(783, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 13);
			this.label10.TabIndex = 49;
			this.label10.Text = "Remarks          :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(783, 49);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 13);
			this.label9.TabIndex = 48;
			this.label9.Text = "Discount          :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(254, 77);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 13);
			this.label8.TabIndex = 47;
			this.label8.Text = "Rate per Unit :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(487, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 13);
			this.label7.TabIndex = 46;
			this.label7.Text = "Size                        :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(254, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 13);
			this.label6.TabIndex = 45;
			this.label6.Text = "Unit               :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 13);
			this.label5.TabIndex = 44;
			this.label5.Text = "Make                :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(487, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 13);
			this.label4.TabIndex = 43;
			this.label4.Text = "Description             :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 42;
			this.label3.Text = "Product Name  :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(783, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 41;
			this.label2.Text = "Sub Category   :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(487, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 40;
			this.label1.Text = "Product Category   :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(50, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 53);
			this.pictureBox1.TabIndex = 85;
			this.pictureBox1.TabStop = false;
			// 
			// frmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
			this.ClientSize = new System.Drawing.Size(1144, 632);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmProduct";
			this.Text = "Product Master";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmProduct_Load);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSubCategory;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductCateId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubCateID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaxID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Make;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn RatePerUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}

