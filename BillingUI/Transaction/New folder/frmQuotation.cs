using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingUI;
using AC.Billing.Business;
namespace AC.Billing.UI.Transaction
{
    public partial class frmQuotation : BaseClass
    {
       

        #region [Variable Declaration]  

        QuotationBLL quotationBLL;
        int UserId = 1;
        int QuotationID;

        #endregion [Variable Declaration]  
        #region [Events] 

        public frmQuotation()
        {
            quotationBLL = new QuotationBLL(dbHelper);
            InitializeComponent();
            gvQuotation.CellContentClick += gvQuotation_CellContentClick;
            FillCombo();
            FillGrid();
        }

        private void frmQuotation_Load(object sender, EventArgs e)
        {

        }

        private void gvQuotation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.gvQuotationItem.DataSource = null;
            var senderGrid = (DataGridView)sender;

            var aa = gvQuotation.CurrentCell.RowIndex;
            if (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 7)
            {
                QuotationID = Convert.ToInt32(gvQuotation.Rows[aa].Cells[0].Value);

                DataTable dtQuotation = new DataTable();
                dtQuotation = quotationBLL.GetAllQuotation(QuotationID);
                if (dtQuotation != null)
                {
                    if (dtQuotation.Rows.Count > 0)
                    {
                        txtName.Text = Convert.ToString(dtQuotation.Rows[0]["CustomerName"]);
                        txtRemarks.Text = Convert.ToString(dtQuotation.Rows[0]["Remarks"]);                        
                        cmbPaymentMode.SelectedValue = Convert.ToString(dtQuotation.Rows[0]["PaymentModeID"]);

                        dtQuotationDate.Text = Convert.ToString(dtQuotation.Rows[0]["QuotationDate"]);
                        dtPurchaseDate.Text = Convert.ToString(dtQuotation.Rows[0]["PurchaseExpectedBy"]);

                    }

                    DataTable dtQuotationItem = new DataTable();
                    dtQuotationItem = quotationBLL.GetAllQuotationItem(QuotationID, 0);
                    gvQuotationItem.AutoGenerateColumns = false;
                    gvQuotationItem.DataSource = dtQuotationItem;
                    GetProduct();                                     

                }
            }
            FillGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            //if (validation() == true)
            {

                DataTable dtQuotation = new DataTable();
                dtQuotation.TableName = "Quotation";
                dtQuotation.Columns.Add("CustomerName", typeof(String));             
                dtQuotation.Columns.Add("PaymentModeID", typeof(Int32));
                dtQuotation.Columns.Add("PaymentMode", typeof(String));
                dtQuotation.Columns.Add("QuotationDate", typeof(String));
                dtQuotation.Columns.Add("PurchaseExpectedBy", typeof(String));
                dtQuotation.Columns.Add("Remarks", typeof(String));

                DataRow rowQuotation = dtQuotation.NewRow();
                rowQuotation["CustomerName"] = txtName.Text.Trim();
                rowQuotation["PaymentModeID"] = cmbPaymentMode.SelectedValue;
                rowQuotation["PaymentMode"] = "Self";
                rowQuotation["QuotationDate"] = Convert.ToDateTime(dtQuotationDate.Value).ToString("MM-dd-yy");
                rowQuotation["PurchaseExpectedBy"] = Convert.ToDateTime(dtPurchaseDate.Value).ToString("MM-dd-yy");
                rowQuotation["Remarks"] = txtRemarks.Text.Trim();
                dtQuotation.Rows.Add(rowQuotation);


                DataTable dtDeliveryItems = new DataTable();
                dtDeliveryItems.TableName = "QuotationDetails";
                dtDeliveryItems.Columns.Add("QuotationItemID", typeof(Int32));
                dtDeliveryItems.Columns.Add("QuotationID", typeof(Int32));
                dtDeliveryItems.Columns.Add("ProductID", typeof(Int32));
                dtDeliveryItems.Columns.Add("Product", typeof(String));
                dtDeliveryItems.Columns.Add("Make", typeof(String));
                dtDeliveryItems.Columns.Add("Quantity", typeof(Decimal));
                dtDeliveryItems.Columns.Add("Unit", typeof(Int32));
                // dtInventoryItems.Columns.Add("SizeID", typeof(Int32));
                dtDeliveryItems.Columns.Add("RatePerUnit", typeof(Decimal));
                dtDeliveryItems.Columns.Add("TaxID", typeof(Int32));
                dtDeliveryItems.Columns.Add("TaxAmount", typeof(Decimal));
                dtDeliveryItems.Columns.Add("DiscountAmount", typeof(Decimal));
                dtDeliveryItems.Columns.Add("TotalAmount", typeof(Decimal));
                dtDeliveryItems.Columns.Add("Remark", typeof(String));
                dtDeliveryItems.Columns.Add("Delete", typeof(Boolean));

                DataRow row;
                for (int i = 0; i < gvQuotationItem.Rows.Count - 1; i++)
                {
                    row = dtDeliveryItems.NewRow();
                    row["QuotationItemID"] = (Convert.ToString(gvQuotationItem.Rows[i].Cells["QuotationItemID"].Value) == "") ? 0 : gvQuotationItem.Rows[i].Cells["QuotationItemID"].Value;
                    //row["InvoiceID"] = gvQuotationItem.Rows[i].Cells["InvoiceID"].Value;
                    //row["ProductID"] = Convert.ToInt32(Product.);
                    row["Product"] = "Product";
                    row["ProductID"] = Convert.ToInt32(gvQuotationItem.Rows[i].Cells["Product"].Value);
                    row["Product"] = Convert.ToString(gvQuotationItem.Rows[i].Cells["Product"].Value);
                    row["Make"] = Convert.ToString(gvQuotationItem.Rows[i].Cells["Make"].Value);
                    row["Quantity"] = Convert.ToDecimal(gvQuotationItem.Rows[i].Cells["Quantity"].Value);
                    row["Unit"] = Convert.ToString(gvQuotationItem.Rows[i].Cells["Unit"].Value);
                    //row["SizeID"] = Convert.ToInt32(gvInventoryItem.Rows[i].Cells["SizeID"].Value);
                    //row["SizeID"] = 1;
                    row["RatePerUnit"] = Convert.ToDecimal(gvQuotationItem.Rows[i].Cells["RateperUnit"].Value);
                    row["TaxID"] = Convert.ToInt32(gvQuotationItem.Rows[i].Cells["Tax"].Value);
                    row["TaxAmount"] = Convert.ToDecimal(gvQuotationItem.Rows[i].Cells["TaxAmt"].Value);
                    row["DiscountAmount"] = Convert.ToDecimal(gvQuotationItem.Rows[i].Cells["DiscountAmt"].Value);
                    row["TotalAmount"] = Convert.ToDecimal(gvQuotationItem.Rows[i].Cells["TotalAmt"].Value);
                    row["Remark"] = Convert.ToString(gvQuotationItem.Rows[i].Cells["Remark"].Value);
                    DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                    ch1 = (DataGridViewCheckBoxCell)gvQuotationItem.Rows[i].Cells[0];
                    row["Delete"] = ch1.Value == null ? false : true;

                    if (!string.IsNullOrEmpty(Convert.ToString(gvQuotationItem.Rows[i].Cells["Make"].Value)))
                        dtDeliveryItems.Rows.Add(row);

    }

                 System.IO.StringWriter swSQL;
                StringBuilder sbSQL1 = new StringBuilder();
                swSQL = new System.IO.StringWriter(sbSQL1);
                dtDeliveryItems.WriteXml(swSQL);
                swSQL.Dispose();

                System.IO.StringWriter swSQL2;
                StringBuilder sbSQL2 = new StringBuilder();
                swSQL2 = new System.IO.StringWriter(sbSQL2);
                dtQuotation.WriteXml(swSQL2);
                swSQL2.Dispose();

                quotationBLL.QuotationSave(QuotationID, sbSQL2.ToString(), sbSQL1.ToString(), UserId);

                QuotationID = 0;
                ClearFields();
                FillGrid();
                // this.gvInventoryItem.DataSource = null;

            }
        }
        #endregion [Events] 

        #region [FillGrid] 

        private void FillGrid()
        {
            DataTable dt = new DataTable();
            dt = quotationBLL.GetAllQuotation(0);
            GridBind(dt);
        }

        private void GridBind(DataTable dt)
        {
            gvQuotation.AutoGenerateColumns = false;
            dt.Columns.Add("Edit");
            gvQuotation.DataSource = dt;
            this.gvQuotation.AllowUserToAddRows = false;
        }

        #endregion [FillGrid]

        #region [Combo Fill] 

        private void GetAllPaymentMode()
        {
            DataTable dt = new DataTable();
            dt = quotationBLL.GetAllPaymentMode();
            cmbPaymentMode.DataSource = dt;
            dt.Rows.Add(new object[] { 0, "Select" });
            dt.DefaultView.Sort = "PaymentModeID";
            cmbPaymentMode.ValueMember = "PaymentModeID";
            cmbPaymentMode.DisplayMember = "PaymentMode";
            cmbPaymentMode.SelectedValue = 0;
        }
      
        private void GetProduct()
        {
            DataTable dt = new DataTable();
            dt = quotationBLL.GetProduct();           
            dt.Rows.Add(new object[] { 0, "Select" });
            var data = dataGridView2.Rows[i].Cells["ProductID"].Value;
            var selectValue = 0;
            if (data != null)
                selectValue = Convert.ToInt32(data);
            Product.DataSource = dt;
            Product.ValueMember = "ProductID";
            Product.DisplayMember = "ProductName";
            //Product. = 0;            
            }


        }
        private void FillCombo()
        {
            GetAllPaymentMode();            
            GetProduct();
        }

        #endregion [Combo Fill] 

        #region [ClearFields] 

        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            cmbPaymentMode.SelectedValue = 0;            
            dtQuotationDate.Value = DateTime.Now;
            dtPurchaseDate.Value = DateTime.Now;
        }

        #endregion [ClearFields] 

        #region [Validation] 

        public void onlynumwithsinglepoint(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        public void onlynumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }




        #endregion [Validation] 

    }
}
