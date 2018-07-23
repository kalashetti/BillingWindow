namespace AC.Billing.UI.Transaction
{
    partial class frmDeliveryNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IsDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DeliveryNoteItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ordGrid = new System.Windows.Forms.DataGrid();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvDeliveryNote = new System.Windows.Forms.DataGridView();
            this.DeliveryNoteID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryModeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editparent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteParent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtEstimatedDate = new System.Windows.Forms.DateTimePicker();
            this.dtDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDeliveryMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbInvoice = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrintGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeliveryNote)).BeginInit();
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
            this.label12.Location = new System.Drawing.Point(507, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 23);
            this.label12.TabIndex = 132;
            this.label12.Text = "Delivery Note";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PrintGrid);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.ordGrid);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(25, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 203);
            this.panel1.TabIndex = 96;
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
            this.DeliveryNoteItemID,
            this.DeliveryNote,
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
            this.dataGridView2.Location = new System.Drawing.Point(3, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1078, 169);
            this.dataGridView2.TabIndex = 98;
            this.dataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            // 
            // IsDelete
            // 
            this.IsDelete.HeaderText = "Select";
            this.IsDelete.Name = "IsDelete";
            this.IsDelete.Width = 60;
            // 
            // DeliveryNoteItemID
            // 
            this.DeliveryNoteItemID.DataPropertyName = "DeliveryNoteItemID";
            this.DeliveryNoteItemID.HeaderText = "InvoiceItemID";
            this.DeliveryNoteItemID.Name = "DeliveryNoteItemID";
            this.DeliveryNoteItemID.ToolTipText = "InvoiceItemID";
            this.DeliveryNoteItemID.Visible = false;
            this.DeliveryNoteItemID.Width = 5;
            // 
            // DeliveryNote
            // 
            this.DeliveryNote.DataPropertyName = "DeliveryNoteID";
            this.DeliveryNote.HeaderText = "InvoiceID";
            this.DeliveryNote.Name = "DeliveryNote";
            this.DeliveryNote.Visible = false;
            this.DeliveryNote.Width = 5;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0";
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.RateperUnit.DefaultCellStyle = dataGridViewCellStyle10;
            this.RateperUnit.HeaderText = "Rate/Unit";
            this.RateperUnit.Name = "RateperUnit";
            this.RateperUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RateperUnit.Width = 75;
            // 
            // Tax
            // 
            this.Tax.DataPropertyName = "TaxPercentage";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Tax.DefaultCellStyle = dataGridViewCellStyle11;
            this.Tax.HeaderText = "Tax %";
            this.Tax.Name = "Tax";
            this.Tax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tax.Width = 50;
            // 
            // TaxAmt
            // 
            this.TaxAmt.DataPropertyName = "TaxAmount";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0";
            this.TaxAmt.DefaultCellStyle = dataGridViewCellStyle12;
            this.TaxAmt.HeaderText = "Tax Amt";
            this.TaxAmt.Name = "TaxAmt";
            this.TaxAmt.ReadOnly = true;
            this.TaxAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TaxAmt.Width = 60;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle13;
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Discount.Width = 60;
            // 
            // DiscountAmt
            // 
            this.DiscountAmt.DataPropertyName = "DiscountAmount";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = "0";
            this.DiscountAmt.DefaultCellStyle = dataGridViewCellStyle14;
            this.DiscountAmt.HeaderText = "Disc. Amt";
            this.DiscountAmt.Name = "DiscountAmt";
            this.DiscountAmt.ReadOnly = true;
            this.DiscountAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DiscountAmt.Width = 80;
            // 
            // TotalAmt
            // 
            this.TotalAmt.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = "0";
            this.TotalAmt.DefaultCellStyle = dataGridViewCellStyle15;
            this.TotalAmt.HeaderText = "Total Amt";
            this.TotalAmt.Name = "TotalAmt";
            this.TotalAmt.ReadOnly = true;
            this.TotalAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            dataGridViewCellStyle16.Format = "C2";
            dataGridViewCellStyle16.NullValue = null;
            this.Remark.DefaultCellStyle = dataGridViewCellStyle16;
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
            // ordGrid
            // 
            this.ordGrid.DataMember = "";
            this.ordGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ordGrid.Location = new System.Drawing.Point(3, 204);
            this.ordGrid.Name = "ordGrid";
            this.ordGrid.Size = new System.Drawing.Size(480, 200);
            this.ordGrid.TabIndex = 97;
            this.ordGrid.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(949, 176);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(122, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(874, 179);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Grand Total :";
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
            this.panel2.Location = new System.Drawing.Point(25, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 37);
            this.panel2.TabIndex = 94;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnPrintPreview.FlatAppearance.BorderSize = 0;
            this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreview.Location = new System.Drawing.Point(637, 10);
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
            this.btnPrint.Location = new System.Drawing.Point(733, 10);
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
            this.btnDeleteRow.Location = new System.Drawing.Point(556, 10);
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
            this.btnAddRow.Location = new System.Drawing.Point(473, 10);
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
            this.btnCancel.Location = new System.Drawing.Point(392, 10);
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
            this.btnSave.Location = new System.Drawing.Point(311, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.gvDeliveryNote);
            this.panel3.Location = new System.Drawing.Point(25, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1088, 177);
            this.panel3.TabIndex = 95;
            // 
            // gvDeliveryNote
            // 
            this.gvDeliveryNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDeliveryNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeliveryNoteID1,
            this.CustomerName,
            this.InvoiceID,
            this.DeliveryDate,
            this.EstimatedDate,
            this.DeliveryMode,
            this.DeliveryModeID,
            this.Remarks,
            this.Editparent,
            this.DeleteParent});
            this.gvDeliveryNote.Location = new System.Drawing.Point(3, 3);
            this.gvDeliveryNote.Name = "gvDeliveryNote";
            this.gvDeliveryNote.Size = new System.Drawing.Size(1078, 167);
            this.gvDeliveryNote.TabIndex = 7;
            // 
            // DeliveryNoteID1
            // 
            this.DeliveryNoteID1.DataPropertyName = "DeliveryNoteID";
            this.DeliveryNoteID1.HeaderText = "DeliveryNoteID";
            this.DeliveryNoteID1.Name = "DeliveryNoteID1";
            this.DeliveryNoteID1.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 250;
            // 
            // InvoiceID
            // 
            this.InvoiceID.DataPropertyName = "InvoiceID";
            this.InvoiceID.HeaderText = "Invoice ID";
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceID.Visible = false;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.HeaderText = "Delivery Date";
            this.DeliveryDate.Name = "DeliveryDate";
            // 
            // EstimatedDate
            // 
            this.EstimatedDate.DataPropertyName = "EstimatedDate";
            this.EstimatedDate.HeaderText = "Est. Delivery  Date";
            this.EstimatedDate.Name = "EstimatedDate";
            this.EstimatedDate.Width = 120;
            // 
            // DeliveryMode
            // 
            this.DeliveryMode.DataPropertyName = "DeliveryMode";
            this.DeliveryMode.HeaderText = "Delivery Mode";
            this.DeliveryMode.Name = "DeliveryMode";
            this.DeliveryMode.Width = 150;
            // 
            // DeliveryModeID
            // 
            this.DeliveryModeID.DataPropertyName = "DeliveryModeID";
            this.DeliveryModeID.HeaderText = "DeliveryModeID";
            this.DeliveryModeID.Name = "DeliveryModeID";
            this.DeliveryModeID.ToolTipText = "DeliveryModeID";
            this.DeliveryModeID.Visible = false;
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
            this.groupBox1.Controls.Add(this.dtEstimatedDate);
            this.groupBox1.Controls.Add(this.dtDeliveryDate);
            this.groupBox1.Controls.Add(this.cmbDeliveryMode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cmbInvoice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 90);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            // 
            // dtEstimatedDate
            // 
            this.dtEstimatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEstimatedDate.Location = new System.Drawing.Point(754, 27);
            this.dtEstimatedDate.Name = "dtEstimatedDate";
            this.dtEstimatedDate.Size = new System.Drawing.Size(139, 20);
            this.dtEstimatedDate.TabIndex = 3;
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeliveryDate.Location = new System.Drawing.Point(439, 57);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(139, 20);
            this.dtDeliveryDate.TabIndex = 2;
            // 
            // cmbDeliveryMode
            // 
            this.cmbDeliveryMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeliveryMode.FormattingEnabled = true;
            this.cmbDeliveryMode.Location = new System.Drawing.Point(122, 58);
            this.cmbDeliveryMode.Name = "cmbDeliveryMode";
            this.cmbDeliveryMode.Size = new System.Drawing.Size(211, 21);
            this.cmbDeliveryMode.TabIndex = 4;
            this.cmbDeliveryMode.SelectedIndexChanged += new System.EventHandler(this.cmbDeliveryMode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Delivery Mode   :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(754, 62);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(285, 20);
            this.txtRemarks.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Remarks                                   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Estimated Delivery Date           :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Delivery Date    :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 20);
            this.txtName.TabIndex = 0;
            // 
            // cmbInvoice
            // 
            this.cmbInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoice.FormattingEnabled = true;
            this.cmbInvoice.Location = new System.Drawing.Point(439, 24);
            this.cmbInvoice.Name = "cmbInvoice";
            this.cmbInvoice.Size = new System.Drawing.Size(139, 21);
            this.cmbInvoice.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Customer Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Invoice No.       :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 53);
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // PrintGrid
            // 
            this.PrintGrid.AllowUserToAddRows = false;
            this.PrintGrid.AllowUserToDeleteRows = false;
            this.PrintGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintGrid.Location = new System.Drawing.Point(3, 117);
            this.PrintGrid.Name = "PrintGrid";
            this.PrintGrid.Size = new System.Drawing.Size(240, 150);
            this.PrintGrid.TabIndex = 136;
            this.PrintGrid.Visible = false;
            // 
            // frmDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1144, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDeliveryNote";
            this.Text = "Delivery Note";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDeliveryNote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDeliveryNote)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbInvoice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDeliveryMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtEstimatedDate;
        private System.Windows.Forms.DateTimePicker dtDeliveryDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvDeliveryNote;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGrid ordGrid;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryNoteID1;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryMode;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryModeID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
		private System.Windows.Forms.DataGridViewButtonColumn Editparent;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteParent;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryNoteItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryNote;
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