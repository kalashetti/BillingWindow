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
using System.Configuration;

namespace AC.Billing.UI.Transaction
{
    public partial class frmStock : BaseClass
    {
        #region [Variable Declaration]

        ProductBLL productBLL;
        InvoiceBLL invoiceBLL;
        StockBLL stockBLL;
		SizeBLL sizeBLL;
		int stockID, UserId = 1;
        DataTable dtStock;
        #endregion [Variable Declaration]
        public frmStock()
        {
            productBLL = new ProductBLL(dbHelper);
            stockBLL = new StockBLL(dbHelper);
			sizeBLL =  new SizeBLL(dbHelper);
			invoiceBLL = new InvoiceBLL(dbHelper);
            InitializeComponent();
            FillCombo();
            FillGrid();
            this.dvStock.AllowUserToAddRows = false;
        }
        private void FillCombo()
        {
            GetProduct();
            GetAllSize();
            GetAllUnit();
            GetAllTax();

        }
        private void GetProduct()
        {
            DataTable dt = new DataTable();
            dt = invoiceBLL.GetProduct();
            cmbProduct.DataSource = dt;
            dt.Rows.Add(new object[] { 0, "Select" });
            dt.DefaultView.Sort = "ProductID ASC";
            cmbProduct.ValueMember = "ProductID";
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.SelectedValue = 0;


        }
        private void GetAllSize()
        {
            DataTable dt = new DataTable();
            dt = productBLL.GetAllSize(null);
            cmbSize.DataSource = dt;
            dt.Rows.Add(new object[] { 0, "Select", "Select" });
            dt.DefaultView.Sort = "SizeID";
            cmbSize.ValueMember = "SizeID";
            cmbSize.DisplayMember = "SizeName";
            cmbSize.SelectedValue = 0;
        }
        private void GetAllUnit()
        {
            DataTable dt = new DataTable();
            dt = productBLL.GetAllUnit(null);
            cbUnit.DataSource = dt;
            dt.Rows.Add(new object[] { 0, "Select", "Select" });
            dt.DefaultView.Sort = "UnitID";
            cbUnit.ValueMember = "UnitID";
            cbUnit.DisplayMember = "Name";
            cbUnit.SelectedValue = 0;
        }

        private void GetAllTax()
        {
            DataTable dt = new DataTable();
            dt = productBLL.GetAllTax(null);
            cmbTax.DataSource = dt;
            dt.Rows.Add(new object[] { 0, "Select" });
            dt.DefaultView.Sort = "TaxID";
            cmbTax.ValueMember = "TaxID";
            cmbTax.DisplayMember = "TaxName";
            cmbTax.SelectedValue = 0;
        }

        private void FillGrid()
        {
            DataTable dt = new DataTable();
            dt = stockBLL.GetAllStock(null);
            GridBind(dt);
        }

        private void GridBind(DataTable dt)
        {

            dvStock.AutoGenerateColumns = false;
            dt.Columns.Add("Edit");
            dvStock.DataSource = dt;
            this.dvStock.AllowUserToAddRows = false;
            dvStock.Columns[3].ReadOnly = true;
          //  stockID = 0;


        }
        private bool validation()
        {
            if ((string.IsNullOrEmpty(cmbProduct.SelectedValue.ToString())) || (cmbProduct.SelectedValue.ToString() == "0"))
            {
                MessageBox.Show("Please Select Product");
                cmbProduct.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMake.Text.Trim()))
            {
                MessageBox.Show("Please enter make");
                txtMake.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtQuantity.Text.Trim()))
            {
                MessageBox.Show("Please enter Quantity");
                txtQuantity.Focus();
                return false;
            }

            if ((string.IsNullOrEmpty(cbUnit.SelectedValue.ToString())) || (cbUnit.SelectedValue.ToString() == "0"))
            {
                MessageBox.Show("Please Select unit");
                cbUnit.Focus();
                return false;
            }


			//if ((string.IsNullOrEmpty(cmbSize.SelectedValue.ToString())) || (cmbSize.SelectedValue.ToString() == "0"))
			//{
			//	MessageBox.Show("Please Select Size");
			//	cmbSize.Focus();
			//	return false;
			//}

			if (string.IsNullOrEmpty(txtDiscount.Text.Trim()))
            {
                MessageBox.Show("Please enter Discount");
                txtDiscount.Focus();
                return false;
            }


            if ((string.IsNullOrEmpty(cmbTax.SelectedValue.ToString())) || (cmbTax.SelectedValue.ToString() == "0"))
            {
                MessageBox.Show("Please Select Tax");
                cmbSize.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(txtRate.Text.Trim()))
            {
                MessageBox.Show("Please enter Rate");
                txtRate.Focus();
                return false;
            }

            if ((string.IsNullOrEmpty(cmbTax.SelectedValue.ToString())) || (cmbTax.SelectedValue.ToString() == "0"))
            {
                MessageBox.Show("Please Select Tax");
                cmbTax.Focus();
                return false;
            }

            return true;
        }
		public int GetIntValue(string data)
		{
			decimal deValue = Convert.ToDecimal(data);
			int i = (Int32)deValue;
			// int.TryParse(data,out i);
			return i;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (validation() == true)
			{
				stockBLL.StockSave(stockID, Convert.ToInt32(cmbProduct.SelectedValue.ToString()), txtMake.Text.Trim(), GetIntValue(txtQuantity.Text), Convert.ToInt32(cbUnit.SelectedValue.ToString())
				   , Convert.ToInt32(cmbTax.SelectedValue.ToString()), Convert.ToInt32(cmbSize.SelectedValue.ToString()), Convert.ToDecimal(txtRate.Text.Trim()), Convert.ToDecimal(txtTaxPer.Text), Convert.ToDecimal(txtTaxAmount.Text.ToString()),
				   Convert.ToDecimal(txtDiscount.Text), Convert.ToDecimal(txtDiscountAmount.Text), Convert.ToDecimal(txtTotalAmount.Text), txtRemark.Text.Trim(), UserId);


				FillGrid();
				// FillCombo();
				ClearFields();
			}
		}
		private void ClearFields()
        {
           
            cmbSize.SelectedValue = 0;
            cmbTax.SelectedValue = 0;
            txtMake.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            cbUnit.SelectedValue = 0;
            txtRate.Text = string.Empty;
            cmbSize.SelectedValue = 0;
            txtTaxPer.Text = string.Empty;
            txtTaxAmount.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtDiscountAmount.Text = string.Empty;
            txtRemark.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            cmbProduct.SelectedValue = 0;
            stockID = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumber(sender, e);
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumwithsinglepoint(sender, e);
        }

        private void txtTaxPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumwithsinglepoint(sender, e);
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumwithsinglepoint(sender, e);
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stockID == 0)
            {
                string selectedVal = cmbProduct.SelectedValue.ToString();
                DataTable dtProduct = new DataTable();
                int productId = 0;
                int.TryParse(selectedVal.ToString(), out productId);

                if (Convert.ToInt32(productId) > 0)
                {
                    dtProduct = productBLL.GetAllProduct(Convert.ToInt32(selectedVal));

                    if (dtProduct != null)
                    {
                        if (dtProduct.Rows.Count > 0)
                        {

                            cmbSize.SelectedValue = dtProduct.Rows[0]["SizeID"].ToString();
                            cmbTax.SelectedValue = dtProduct.Rows[0]["TaxID"].ToString();
                            txtMake.Text = dtProduct.Rows[0]["Make"].ToString();
                            txtQuantity.Text = "0";
                            cbUnit.SelectedValue = dtProduct.Rows[0]["UnitID"].ToString();

                            txtRate.Text = dtProduct.Rows[0]["RatePerUnit"].ToString();
                            cmbSize.SelectedValue = dtProduct.Rows[0]["SizeID"].ToString();
                            txtTaxPer.Text = dtProduct.Rows[0]["TaxPercentage"].ToString();
                            txtTaxAmount.Text = "0";
                            txtDiscount.Text = dtProduct.Rows[0]["Discount"].ToString();
                            txtDiscountAmount.Text = "0";

                            txtRemark.Text = dtProduct.Rows[0]["Remark"].ToString();
                            txtTotalAmount.Text = "0";

                        }
                    }

                }
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTaxAmount.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    decimal outValue = 0;
                    Decimal.TryParse(txtTaxPer.Text, out outValue);

                    decimal QuantityRate = Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(txtRate.Text);
                    decimal dicountPer = QuantityRate / 100 * Convert.ToDecimal(txtDiscount.Text);
                    txtDiscountAmount.Text = dicountPer.ToString();

                    decimal totalafterDiscount = QuantityRate - dicountPer;

                    decimal totalTax = totalafterDiscount / 100 * Convert.ToDecimal(outValue);
                    txtTaxAmount.Text = totalTax.ToString();
                    txtTotalAmount.Text = Convert.ToDecimal(totalafterDiscount + totalTax).ToString();
                }
            }

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTaxAmount.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtRate.Text))
                { 
                    decimal outValue = 0;
                Decimal.TryParse(txtTaxPer.Text, out outValue);

                decimal QuantityRate = Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(txtRate.Text);
                decimal dicountPer = QuantityRate / 100 * Convert.ToDecimal(txtDiscount.Text);
                txtDiscountAmount.Text = dicountPer.ToString();

                decimal totalafterDiscount = QuantityRate - dicountPer;

                decimal totalTax = totalafterDiscount / 100 * Convert.ToDecimal(outValue);
                txtTaxAmount.Text = totalTax.ToString();
                txtTotalAmount.Text = Convert.ToDecimal(totalafterDiscount + totalTax).ToString();
              } 
            }
        }

        private void txtTaxPer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTaxAmount.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtTaxPer.Text))
                {
                    decimal outValue = 0;
                    Decimal.TryParse(txtTaxPer.Text, out outValue);

                    decimal QuantityRate = Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(txtRate.Text);
                    decimal dicountPer = QuantityRate / 100 * Convert.ToDecimal(txtDiscount.Text);
                    txtDiscountAmount.Text = dicountPer.ToString();

                    decimal totalafterDiscount = QuantityRate - dicountPer;

                    decimal totalTax = totalafterDiscount / 100 * Convert.ToDecimal(outValue);
                    txtTaxAmount.Text = totalTax.ToString();
                    txtTotalAmount.Text = Convert.ToDecimal(totalafterDiscount + totalTax).ToString();
                }
            }
           
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTaxAmount.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
                {
                    decimal outValue = 0;
                    Decimal.TryParse(txtTaxPer.Text, out outValue);

                    decimal QuantityRate = Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(txtRate.Text);
                    decimal dicountPer = QuantityRate / 100 * Convert.ToDecimal(txtDiscount.Text);
                    txtDiscountAmount.Text = dicountPer.ToString();

                    decimal totalafterDiscount = QuantityRate - dicountPer;

                    decimal totalTax = totalafterDiscount / 100 * Convert.ToDecimal(outValue);
                    txtTaxAmount.Text = totalTax.ToString();
                    txtTotalAmount.Text = Convert.ToDecimal(totalafterDiscount + totalTax).ToString();
                }
            }

        }

        private void dvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            var aa = dvStock.CurrentCell.RowIndex;
            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 16 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dvStock.Rows[aa].Cells[18].Value.ToString()))))
            {
                stockID = Convert.ToInt32(dvStock.Rows[aa].Cells[18].Value);
                DataTable dtStock = new DataTable();
                dtStock = stockBLL.GetAllStock(stockID);
                cmbSize.SelectedValue = dtStock.Rows[0]["SizeID"].ToString();
                cmbTax.SelectedValue = dtStock.Rows[0]["TaxID"].ToString();
                txtMake.Text = dtStock.Rows[0]["Make"].ToString();
                txtQuantity.Text = dtStock.Rows[0]["Quantity"].ToString();
                cbUnit.SelectedValue = dtStock.Rows[0]["UnitID"].ToString();
                txtRate.Text = dtStock.Rows[0]["RatePerUnit"].ToString();
                cmbSize.SelectedValue = dtStock.Rows[0]["SizeID"].ToString();
                txtTaxPer.Text = dtStock.Rows[0]["TaxPercentage"].ToString();
                txtTaxAmount.Text = dtStock.Rows[0]["TaxAmount"].ToString();
                txtDiscount.Text = dtStock.Rows[0]["Discount"].ToString();
                txtDiscountAmount.Text = dtStock.Rows[0]["DiscountAmount"].ToString();
                txtRemark.Text = dtStock.Rows[0]["Remark"].ToString();
                txtTotalAmount.Text = dtStock.Rows[0]["TotalAmount"].ToString();
                cmbProduct.SelectedValue = dtStock.Rows[0]["ProductID"].ToString();

            }
            else if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (senderGrid.Columns[e.ColumnIndex].DisplayIndex == 17 && e.RowIndex >= 0) && (!(String.IsNullOrEmpty(dvStock.Rows[aa].Cells[18].Value.ToString()))))
            {

                if (ShowDeleteConfirmMessage())
                {
                    stockID = Convert.ToInt32(dvStock.Rows[aa].Cells[18].Value);
                    bool check = stockBLL.StockDelete(stockID, DateTime.Now, UserId);
                    if (check == true)
                        MessageBox.Show("Selected stock Deleted Successfully.");
                    else
                        MessageBox.Show("Selected stock cannot be deleted due to mapping with other masters.");
                }
                ClearFields();
            }
            FillGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

		private void frmStock_Load(object sender, EventArgs e)
		{
			string logoPath = ConfigurationManager.AppSettings["LogoPath"].ToString();
			Image image = Image.FromFile(logoPath);
			//Image image = Image.FromFile("C:\\lekka.png");
			// Set the PictureBox image property to this image.
			// ... Then, adjust its height and width properties.
			pictureBox1.Image = image;
			pictureBox1.Height = 54;
			pictureBox1.Width = 70;
		}

		private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void cbUnit_SelectionChangeCommitted(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			int unit = Convert.ToInt32(cbUnit.SelectedValue.ToString());
			dt = sizeBLL.GetAllSize(null, unit);
			dt.Rows.Add(new object[] { 0, "Select" });
			dt.DefaultView.Sort = "SizeId ASC";
			cmbSize.DataSource = dt;
			cmbSize.ValueMember = "SizeID";
			cmbSize.DisplayMember = "SizeName";
		}

		public void onlynumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
