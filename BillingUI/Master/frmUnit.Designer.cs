namespace AC.Billing.UI.Master
{
    partial class frmUnit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblDescription = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTaxName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Size,
            this.UnitName,
            this.Description,
            this.Edit,
            this.Delete});
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(649, 329);
			this.dataGridView1.TabIndex = 77;
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(338, 9);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(305, 20);
			this.txtDesc.TabIndex = 6;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(83, 9);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(141, 20);
			this.txtName.TabIndex = 4;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(340, 16);
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
			this.btnSave.Location = new System.Drawing.Point(246, 16);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 48;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Location = new System.Drawing.Point(236, 158);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(659, 51);
			this.panel2.TabIndex = 75;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.ForeColor = System.Drawing.Color.White;
			this.lblDescription.Location = new System.Drawing.Point(264, 12);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(66, 13);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "Description :";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.txtDesc);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.lblTaxName);
			this.panel1.Controls.Add(this.lblDescription);
			this.panel1.Location = new System.Drawing.Point(236, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(659, 43);
			this.panel1.TabIndex = 76;
			// 
			// lblTaxName
			// 
			this.lblTaxName.AutoSize = true;
			this.lblTaxName.ForeColor = System.Drawing.Color.White;
			this.lblTaxName.Location = new System.Drawing.Point(14, 12);
			this.lblTaxName.Name = "lblTaxName";
			this.lblTaxName.Size = new System.Drawing.Size(63, 13);
			this.lblTaxName.TabIndex = 0;
			this.lblTaxName.Text = "Unit Name :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(501, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 23);
			this.label1.TabIndex = 78;
			this.label1.Text = "Unit Master";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(236, 49);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 53);
			this.pictureBox1.TabIndex = 82;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Location = new System.Drawing.Point(236, 215);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(659, 349);
			this.panel3.TabIndex = 73;
			// 
			// Size
			// 
			this.Size.DataPropertyName = "UnitID";
			this.Size.HeaderText = "UnitID";
			this.Size.Name = "Size";
			this.Size.Visible = false;
			// 
			// UnitName
			// 
			this.UnitName.DataPropertyName = "Name";
			this.UnitName.HeaderText = "Unit Name";
			this.UnitName.Name = "UnitName";
			this.UnitName.Width = 250;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.Width = 240;
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
			// frmUnit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
			this.ClientSize = new System.Drawing.Size(1144, 632);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUnit";
			this.Text = "Unit Master";
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Size;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
		private System.Windows.Forms.Panel panel3;
	}
}