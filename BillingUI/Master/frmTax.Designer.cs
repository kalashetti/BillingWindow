namespace AC.Billing.UI.Master
{
    partial class frmTax
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTax));
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtEffectiveDate = new System.Windows.Forms.DateTimePicker();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.txtPer = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblTaxName = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblEffectiveFrom = new System.Windows.Forms.Label();
			this.lblPer = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TaxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TaxPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EffectiveFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(501, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 23);
			this.label1.TabIndex = 79;
			this.label1.Text = "Tax Master";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TaxName,
            this.TaxPercentage,
            this.Description,
            this.EffectiveFrom,
            this.Edit,
            this.Delete});
			this.dataGridView1.Location = new System.Drawing.Point(3, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(648, 323);
			this.dataGridView1.TabIndex = 74;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.dtEffectiveDate);
			this.panel1.Controls.Add(this.txtDesc);
			this.panel1.Controls.Add(this.txtPer);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.lblTaxName);
			this.panel1.Controls.Add(this.lblDescription);
			this.panel1.Controls.Add(this.lblEffectiveFrom);
			this.panel1.Controls.Add(this.lblPer);
			this.panel1.Location = new System.Drawing.Point(242, 89);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(659, 118);
			this.panel1.TabIndex = 73;
			// 
			// dtEffectiveDate
			// 
			this.dtEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtEffectiveDate.Location = new System.Drawing.Point(532, 55);
			this.dtEffectiveDate.Name = "dtEffectiveDate";
			this.dtEffectiveDate.Size = new System.Drawing.Size(119, 20);
			this.dtEffectiveDate.TabIndex = 75;
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(85, 55);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(240, 20);
			this.txtDesc.TabIndex = 6;
			// 
			// txtPer
			// 
			this.txtPer.Location = new System.Drawing.Point(532, 9);
			this.txtPer.Name = "txtPer";
			this.txtPer.Size = new System.Drawing.Size(119, 20);
			this.txtPer.TabIndex = 5;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(85, 9);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(239, 20);
			this.txtName.TabIndex = 4;
			// 
			// lblTaxName
			// 
			this.lblTaxName.AutoSize = true;
			this.lblTaxName.ForeColor = System.Drawing.Color.White;
			this.lblTaxName.Location = new System.Drawing.Point(14, 12);
			this.lblTaxName.Name = "lblTaxName";
			this.lblTaxName.Size = new System.Drawing.Size(65, 13);
			this.lblTaxName.TabIndex = 0;
			this.lblTaxName.Text = "Tax Name  :";
			this.lblTaxName.Click += new System.EventHandler(this.lblTaxName_Click);
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.ForeColor = System.Drawing.Color.White;
			this.lblDescription.Location = new System.Drawing.Point(14, 58);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(66, 13);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "Description :";
			// 
			// lblEffectiveFrom
			// 
			this.lblEffectiveFrom.AutoSize = true;
			this.lblEffectiveFrom.ForeColor = System.Drawing.Color.White;
			this.lblEffectiveFrom.Location = new System.Drawing.Point(336, 58);
			this.lblEffectiveFrom.Name = "lblEffectiveFrom";
			this.lblEffectiveFrom.Size = new System.Drawing.Size(192, 13);
			this.lblEffectiveFrom.TabIndex = 3;
			this.lblEffectiveFrom.Text = "Effective From                                      :";
			this.lblEffectiveFrom.Click += new System.EventHandler(this.lblEffectiveFrom_Click);
			// 
			// lblPer
			// 
			this.lblPer.AutoSize = true;
			this.lblPer.ForeColor = System.Drawing.Color.White;
			this.lblPer.Location = new System.Drawing.Point(336, 12);
			this.lblPer.Name = "lblPer";
			this.lblPer.Size = new System.Drawing.Size(193, 13);
			this.lblPer.TabIndex = 1;
			this.lblPer.Text = "Tax Percentage (e.g for 12% enter 12) :";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Location = new System.Drawing.Point(242, 213);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(659, 51);
			this.panel2.TabIndex = 72;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(344, 13);
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
			this.btnSave.Location = new System.Drawing.Point(250, 13);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 48;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(242, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 53);
			this.pictureBox1.TabIndex = 82;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Location = new System.Drawing.Point(242, 271);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(659, 349);
			this.panel3.TabIndex = 83;
			// 
			// ID
			// 
			this.ID.DataPropertyName = "TaxID";
			this.ID.HeaderText = "Tax ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			// 
			// TaxName
			// 
			this.TaxName.DataPropertyName = "TaxName";
			this.TaxName.HeaderText = "Tax Name";
			this.TaxName.Name = "TaxName";
			this.TaxName.Width = 150;
			// 
			// TaxPercentage
			// 
			this.TaxPercentage.DataPropertyName = "TaxPercentage";
			this.TaxPercentage.FillWeight = 130F;
			this.TaxPercentage.HeaderText = "Tax %";
			this.TaxPercentage.Name = "TaxPercentage";
			this.TaxPercentage.Width = 80;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.Width = 170;
			// 
			// EffectiveFrom
			// 
			this.EffectiveFrom.DataPropertyName = "EffectiveFrom";
			this.EffectiveFrom.HeaderText = "Effective From";
			this.EffectiveFrom.Name = "EffectiveFrom";
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
			// frmTax
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
			this.ClientSize = new System.Drawing.Size(1144, 632);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTax";
			this.Text = "Tax Master";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmTax_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxName;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEffectiveFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtEffectiveDate;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaxName;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaxPercentage;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveFrom;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
		private System.Windows.Forms.Panel panel3;
	}
}