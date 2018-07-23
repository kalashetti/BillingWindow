namespace AC.Billing.UI.Master
{
    partial class frmSize
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSize));
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbUnit = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblTaxName = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(508, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 23);
			this.label2.TabIndex = 80;
			this.label2.Text = "Size Master";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Size,
            this.Unit,
            this.SizeName,
            this.UnitID,
            this.SizeDescription,
            this.Edit,
            this.Delete});
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(649, 332);
			this.dataGridView1.TabIndex = 77;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Location = new System.Drawing.Point(234, 200);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(659, 51);
			this.panel2.TabIndex = 75;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(343, 12);
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
			this.btnSave.Location = new System.Drawing.Point(249, 12);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 48;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.cbUnit);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtDesc);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.lblDescription);
			this.panel1.Controls.Add(this.lblTaxName);
			this.panel1.Location = new System.Drawing.Point(234, 106);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(659, 88);
			this.panel1.TabIndex = 76;
			// 
			// cbUnit
			// 
			this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUnit.FormattingEnabled = true;
			this.cbUnit.Location = new System.Drawing.Point(89, 11);
			this.cbUnit.Name = "cbUnit";
			this.cbUnit.Size = new System.Drawing.Size(296, 21);
			this.cbUnit.TabIndex = 53;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(20, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Unit Name :";
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(89, 50);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(554, 20);
			this.txtDesc.TabIndex = 6;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(461, 11);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(182, 20);
			this.txtName.TabIndex = 4;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.ForeColor = System.Drawing.Color.White;
			this.lblDescription.Location = new System.Drawing.Point(17, 53);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(66, 13);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "Description :";
			// 
			// lblTaxName
			// 
			this.lblTaxName.AutoSize = true;
			this.lblTaxName.ForeColor = System.Drawing.Color.White;
			this.lblTaxName.Location = new System.Drawing.Point(422, 14);
			this.lblTaxName.Name = "lblTaxName";
			this.lblTaxName.Size = new System.Drawing.Size(33, 13);
			this.lblTaxName.TabIndex = 0;
			this.lblTaxName.Text = "Size :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(234, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 53);
			this.pictureBox1.TabIndex = 81;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel3.Location = new System.Drawing.Point(234, 257);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(659, 349);
			this.panel3.TabIndex = 82;
			// 
			// Size
			// 
			this.Size.DataPropertyName = "SizeID";
			this.Size.HeaderText = "SizeID";
			this.Size.Name = "Size";
			this.Size.Visible = false;
			// 
			// Unit
			// 
			this.Unit.DataPropertyName = "UnitName";
			this.Unit.HeaderText = "Unit Name";
			this.Unit.Name = "Unit";
			this.Unit.ReadOnly = true;
			this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Unit.Width = 150;
			// 
			// SizeName
			// 
			this.SizeName.DataPropertyName = "SizeName";
			this.SizeName.HeaderText = "Size Name";
			this.SizeName.Name = "SizeName";
			this.SizeName.Width = 150;
			// 
			// UnitID
			// 
			this.UnitID.DataPropertyName = "UnitID";
			this.UnitID.HeaderText = "UnitID";
			this.UnitID.Name = "UnitID";
			this.UnitID.Visible = false;
			// 
			// SizeDescription
			// 
			this.SizeDescription.DataPropertyName = "SizeDescription";
			this.SizeDescription.HeaderText = "Description";
			this.SizeDescription.Name = "SizeDescription";
			this.SizeDescription.Width = 190;
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
			this.Delete.Width = 60;
			// 
			// frmSize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
			this.ClientSize = new System.Drawing.Size(1144, 632);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSize";
			this.Text = "Size Master";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmSize_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTaxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Size;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeDescription;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
		private System.Windows.Forms.Panel panel3;
	}
}