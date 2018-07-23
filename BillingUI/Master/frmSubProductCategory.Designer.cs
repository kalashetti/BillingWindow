namespace AC.Billing.UI.Master
{
    partial class frmSubProductCategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubProductCategory));
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbProductCategory = new System.Windows.Forms.ComboBox();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ProductSubCateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductCateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(467, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 23);
			this.label2.TabIndex = 82;
			this.label2.Text = "Product Subcategory Master";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbProductCategory);
			this.groupBox1.Controls.Add(this.txtDesc);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(144, 96);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(825, 111);
			this.groupBox1.TabIndex = 73;
			this.groupBox1.TabStop = false;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(534, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(285, 20);
			this.txtName.TabIndex = 40;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(420, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 13);
			this.label1.TabIndex = 39;
			this.label1.Text = "Subcategory Name :";
			// 
			// cmbProductCategory
			// 
			this.cmbProductCategory.DisplayMember = "0";
			this.cmbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProductCategory.FormattingEnabled = true;
			this.cmbProductCategory.Items.AddRange(new object[] {
            "Select Category"});
			this.cmbProductCategory.Location = new System.Drawing.Point(117, 24);
			this.cmbProductCategory.Name = "cmbProductCategory";
			this.cmbProductCategory.Size = new System.Drawing.Size(285, 21);
			this.cmbProductCategory.TabIndex = 38;
			this.cmbProductCategory.ValueMember = "0";
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(117, 66);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(702, 20);
			this.txtDesc.TabIndex = 35;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 13);
			this.label4.TabIndex = 33;
			this.label4.Text = "Description            :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 13);
			this.label3.TabIndex = 32;
			this.label3.Text = "Product  Category :";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Location = new System.Drawing.Point(144, 270);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(825, 349);
			this.panel3.TabIndex = 72;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductSubCateID,
            this.ProductCateId,
            this.CategoryName,
            this.SubCategory,
            this.Description,
            this.Edit,
            this.Delete});
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(815, 299);
			this.dataGridView1.TabIndex = 22;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Location = new System.Drawing.Point(144, 213);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(825, 51);
			this.panel2.TabIndex = 71;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(427, 14);
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
			this.btnSave.Location = new System.Drawing.Point(326, 14);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 48;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(144, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 53);
			this.pictureBox1.TabIndex = 83;
			this.pictureBox1.TabStop = false;
			// 
			// ProductSubCateID
			// 
			this.ProductSubCateID.DataPropertyName = "ProductSubCategoryID";
			this.ProductSubCateID.HeaderText = "ProductSubCategoryID";
			this.ProductSubCateID.Name = "ProductSubCateID";
			this.ProductSubCateID.Visible = false;
			// 
			// ProductCateId
			// 
			this.ProductCateId.DataPropertyName = "ProductCategoryID";
			this.ProductCateId.HeaderText = "ProductCateId";
			this.ProductCateId.Name = "ProductCateId";
			this.ProductCateId.Visible = false;
			// 
			// CategoryName
			// 
			this.CategoryName.DataPropertyName = "CategoryName";
			this.CategoryName.HeaderText = "Product Category Name";
			this.CategoryName.Name = "CategoryName";
			this.CategoryName.Width = 200;
			// 
			// SubCategory
			// 
			this.SubCategory.DataPropertyName = "SubCategoryName";
			this.SubCategory.HeaderText = "Subcategory Name";
			this.SubCategory.Name = "SubCategory";
			this.SubCategory.Width = 220;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.Width = 250;
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
			// frmSubProductCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
			this.ClientSize = new System.Drawing.Size(1144, 632);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSubProductCategory";
			this.Text = "Product Subcategory Master";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmSubProductCategory_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubCateID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductCateId;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}